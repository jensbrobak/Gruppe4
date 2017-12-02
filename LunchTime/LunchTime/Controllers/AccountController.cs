using LunchTime.Data;
using LunchTime.Data.Entities;
using LunchTime.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<Customer> _signInManager;
        private readonly UserManager<Customer> _userManager;
        private readonly LunchTimeContext _ctx;

        public AccountController(ILogger<AccountController> logger, SignInManager<Customer> signInManager, UserManager<Customer> userManager, LunchTimeContext ctx)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _ctx = ctx;
        }



        //[HttpGet("login")]
        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "App");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }
                    else
                    {
                        
                        return RedirectToAction("MyPage", "Account");
                    }
                }
            }
                ModelState.AddModelError("", "Failed to login");
            
            return View();
        }



        [Authorize]
        [HttpGet("mypage")]
        public async Task<IActionResult> MyPage()
        {
            AccountViewModel model = new AccountViewModel();

            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            model.Name = user.Name;
            model.Currency = user.Currency;

            return View(model);
        }

        [HttpPost("mypage")]
        public Task<IActionResult> mypage(AccountViewModel model)
        {
            if (ModelState.IsValid)
            {
               var user = _userManager.FindByEmailAsync(User.Identity.Name).Result;

                user.Currency = model.Currency;

                _ctx.Update(user);
                _ctx.SaveChanges();
            }
            return MyPage();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "App");
        }

    }
}
