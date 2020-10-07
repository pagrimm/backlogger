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
      if (searchOption == "games") {
        RawgSearchRoot results = Rawg.GetGamesSearch(searchString, page);
        model.GamesSearch = results;
        model.Results = results.Count;
        model.Pages = (results.Count + 19) / 20;
        model.CurrentPage = page;
      }
      else if (searchOption == "movies")
      {
        TmdbMovieSearchRoot results = Tmdb.GetMoviesSearch(searchString, page);
        model.MovieSearch = results;
        model.Results = results.TotalResults;
        model.Pages = results.TotalPages;
        model.CurrentPage = page;
      }
      else if (searchOption == "tv")
      {
        TmdbTvSearchRoot results = Tmdb.GetTvSearch(searchString, page);
        model.TvSearch = results;
        model.Results = results.TotalResults;
        model.Pages = results.TotalPages;
        model.CurrentPage = page;
      }
      return View(model);
    }
  }
}