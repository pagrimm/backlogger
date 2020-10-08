using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Backlogger.Models;
using System.Threading.Tasks;
using Backlogger.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System;

namespace Backlogger.Controllers
{
  public class AccountController: Controller
  {
    private readonly BackloggerContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, BackloggerContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      return View(currentUser);
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.UserName, Email = model.Email};
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Login");
      }
      else
      {
        return RedirectToAction("Index", "Home");
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index", "Home");
    }

    public async Task<ActionResult> Edit(string id)
    {
      var user = await _userManager.FindByIdAsync(id);
      var model = new RegisterViewModel { Email = user.Email, UserName = user.UserName };
      return View(model);
    }

    [HttpPost]
    public async Task<ActionResult> Edit(RegisterViewModel model, string id)
    {
      var user = await _userManager.FindByIdAsync(id);
      user.UserName = model.UserName;
      user.Email = model.Email;
      if (!String.IsNullOrEmpty(model.Password)) {
        await _userManager.RemovePasswordAsync(user);
        await _userManager.AddPasswordAsync(user, model.Password);
      }
      var result = await _userManager.UpdateAsync(user);
      if (result.Succeeded)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View();
      }
    }
  }
}