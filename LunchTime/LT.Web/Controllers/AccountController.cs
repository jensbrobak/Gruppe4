using System.Linq;
using System.Threading.Tasks;
using LT.Web.Data.Entities;
using LT.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LT.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<Customer> _signInManager;

        public AccountController(ILogger<AccountController> logger, SignInManager<Customer> signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;
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
        public async Task<IActionResult> Login(LoginViewModel model) //TODO fix this
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(model.UserName.ToString(), model.Password.ToString(), model.RememberMe, false);  

                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        Redirect(Request.Query["ReturnUrl"].First());
                    }
                    else
                    {
                        RedirectToAction("Shop", "App");
                    }
                }

            }
            ModelState.AddModelError("", "Failed to login");

            return View();
        }
    }
}
