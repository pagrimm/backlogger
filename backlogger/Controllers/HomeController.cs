using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Backlogger.Models;
using Backlogger.ViewModels;
using Backlogger.ApiModels;

namespace Backlogger.Controllers
{
    public class HomeController : Controller
    {
        private readonly BackloggerContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(BackloggerContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        } 
        public IActionResult Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            List<ItemUser> joinList = _db.ItemUser.Where(join => join.UserId == userId).Include(join => join.Item).ToList();
            List<Item> userItems = new List<Item>();
            foreach(ItemUser join in joinList)
            {
                userItems.Add(join.Item);
            }
            HomeIndexViewModel model = new HomeIndexViewModel
            {
                TotalBacklog = userItems.Count,
                CompletedBacklog = userItems.Where(item => item.Watched == true).ToList().Count,
                TotalGames = userItems.Where(item => item.Type == "game").ToList().Count,
                CompletedGames = userItems.Where(item => item.Type == "game" && item.Watched == true).ToList().Count,
                TotalMovies = userItems.Where(item => item.Type == "movie").ToList().Count,
                CompletedMovies = userItems.Where(item => item.Type == "movie" && item.Watched == true).ToList().Count,
                TotalTv = userItems.Where(item => item.Type == "tv").ToList().Count,
                CompletedTv = userItems.Where(item => item.Type == "tv" && item.Watched == true).ToList().Count, 
            };
            List<Item> orderedItems = userItems.Where(item => item.Watched == false).OrderByDescending(item => item.AddedDate).ToList();
            model.RecentItems = orderedItems.Take(5).ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }   
    }
}