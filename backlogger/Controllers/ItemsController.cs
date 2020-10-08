using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backlogger.Models;
using Backlogger.ViewModels;
using Backlogger.ApiModels;

namespace Backlogger.Controllers
{
  public class ItemsController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Index (string searchOption = null, string searchString = null, int page = 1)
    {
      if (String.IsNullOrEmpty(searchString))
      {
        return RedirectToAction("Index", "Home");
      }
      ItemIndexPostViewModel model = new ItemIndexPostViewModel();
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
  }
}