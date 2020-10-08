using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Backlogger.Models;
using Backlogger.ViewModels;
using Backlogger.ApiModels;

namespace Backlogger.Controllers
{
  public class ItemsController : Controller
  {
    private readonly BackloggerContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public ItemsController(BackloggerContext db, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _userManager = userManager;
    } 
    public IActionResult Index(string typeFilter)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      List<ItemUser> joinList = _db.ItemUser.Where(join => join.UserId == userId).Include(join => join.Item).ToList();
      List<Item> userItems = new List<Item>();
      foreach(ItemUser join in joinList)
      {
        userItems.Add(join.Item);
      }
      ItemIndexViewModel model = new ItemIndexViewModel();
      model.ItemList = userItems;
      if (typeFilter != null) {
        List<Item> filteredItems = userItems.Where(item => item.Type == typeFilter).ToList();
        model.ItemList = filteredItems;
      }
      return View(model);
    }

    [HttpPost]
    public IActionResult Index (string searchOption = null, string searchString = null, int page = 1)
    {
      if (String.IsNullOrEmpty(searchString))
      {
        return RedirectToAction("Index", "Home");
      }
      ItemIndexViewModel model = new ItemIndexViewModel();
      model.CurrentPage = page;
      model.SearchOption = searchOption;
      model.SearchString = searchString;
      if (searchOption == "games")
      {
        RawgSearchRoot results = Rawg.GetGamesSearch(searchString, page);
        model.GamesSearch = results;
        model.Results = results.Count;
        model.Pages = (results.Count + 19) / 20;
      }
      else if (searchOption == "movies")
      {
        TmdbMovieSearchRoot results = Tmdb.GetMoviesSearch(searchString, page);
        model.MovieSearch = results;
        model.Results = results.TotalResults;
        model.Pages = results.TotalPages;
      }
      else if (searchOption == "tv")
      {
        TmdbTvSearchRoot results = Tmdb.GetTvSearch(searchString, page);
        model.TvSearch = results;
        model.Results = results.TotalResults;
        model.Pages = results.TotalPages;
      }
      return View(model);
    }

    public IActionResult Details(long id, string type, string screenshot = null)
    {
      ItemDetailsViewModel model = new ItemDetailsViewModel();
      if (type == "game")
      {
        RawgIdRoot result = Rawg.GetGameById(id);
        model.GameDetails = result;
        model.ScreenShot = screenshot;
      }
      else if (type == "movie")
      {
        TmdbMovieRoot result = Tmdb.GetMovieById(id);
        model.MovieDetails = result;
      }
      else if (type == "tv")
      {
        TmdbTvRoot result = Tmdb.GetTvById(id);
        model.TvDetails = result;
      }
      return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(long id, string type, string screenshot)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      Item newItem = new Item();
      if (type == "game")
      {
        RawgIdRoot itemDetails = Rawg.GetGameById(id);
        newItem.GetRawgValues(itemDetails);
        newItem.Poster = screenshot;
        newItem.Priority = currentUser.PriorityValue;
        _db.Items.Add(newItem);
        ItemUser newItemUser = new ItemUser{Item = newItem, User = currentUser, ItemId = newItem.ItemId, UserId = userId};
        _db.ItemUser.Add(newItemUser);
        currentUser.PriorityValue++;
        var result = await _userManager.UpdateAsync(currentUser);
        _db.SaveChanges();
      }
      else if (type == "movie")
      {
        TmdbMovieRoot itemDetails = Tmdb.GetMovieById(id);
        newItem.GetTmdbMovieValues(itemDetails);
        newItem.Priority = currentUser.PriorityValue;
        _db.Items.Add(newItem);
        ItemUser newItemUser = new ItemUser{Item = newItem, User = currentUser, ItemId = newItem.ItemId, UserId = userId};
        _db.ItemUser.Add(newItemUser);
        currentUser.PriorityValue++;
        var result = await _userManager.UpdateAsync(currentUser);
        _db.SaveChanges();
      }
      else if (type == "tv")
      {
        TmdbTvRoot itemDetails = Tmdb.GetTvById(id);
        newItem.GetTmdbTvValues(itemDetails);
        newItem.Priority = currentUser.PriorityValue;
        _db.Items.Add(newItem);
        ItemUser newItemUser = new ItemUser{Item = newItem, User = currentUser, ItemId = newItem.ItemId, UserId = userId};
        _db.ItemUser.Add(newItemUser);
        currentUser.PriorityValue++;
        var result = await _userManager.UpdateAsync(currentUser);
        _db.SaveChanges();
      }
      return RedirectToAction("Index", "Items");
    }
  }
}