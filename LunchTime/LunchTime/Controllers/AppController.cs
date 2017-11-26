using LunchTime.Data;
using LunchTime.Data.Entities;
using LunchTime.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime.Controllers
{
    public class AppController : Controller
    {
        private readonly ILunchTimeRepository _repository;

        public AppController(ILunchTimeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        //[HttpPost("login")]
        //public IActionResult Login()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var results = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
        //        _repository.CustomerLoginAsync(model.Username, model.Password);
        //        Customer cur = new Customer();
        //        cur = results;

        //        if (cur != null)
        //        {
        //            RedirectToAction("shop", "App");
        //        }
        //    }
        //    return View();
        //}

        [HttpGet("shop")]
        public IActionResult Shop()
        {
            
            //var results = _context.Products 
            //    .OrderBy(p => p.Category)
            //    .ToList();
            //return View();
            //Does the same as:
            //var results = from p in _context.Products
            //              orderby p.Category
            //              select p;

            //return View(results.ToList());

            var results = _repository.GetAllProducts();

            return View(results);
        }

        //[Authorize]
        [HttpGet("cart")]
        public IActionResult Cart()
        {
            return View();
        }
        
    }
}
