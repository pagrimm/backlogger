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
    public IActionResult Index (string searchOption, string searchString)
    {
      ItemIndexPostViewModel model = new ItemIndexPostViewModel();
      if (searchOption == "games") {
        RawgSearchRoot results = Rawg.GetGamesSearch(searchString);
        model.GamesSearch = results;
      }
      else if (searchOption == "movies")
      {
        TmdbMovieSearchRoot results = Tmdb.GetMoviesSearch(searchString);
        model.MovieSearch = results;
      }
      else if (searchOption == "tv")
      {
        TmdbTvSearchRoot results = Tmdb.GetTvSearch(searchString);
        model.TvSearch = results;
      }
      else
      {
        RedirectToAction("Home", "Index");
      }
      return View(model);
    }
  }
}