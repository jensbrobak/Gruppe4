using LunchTime.Data;
using LunchTime.Services;
using LunchTime.ViewModels;
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
        private readonly IMailService _mailService;
        private readonly ILunchTimeRepository _repository;

        public AppController(IMailService mailService, ILunchTimeRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            //throw new InvalidOperationException("Bad things happend");

            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send the email
                _mailService.SendMessage("s@mail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message} ");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }

            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

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

        public IActionResult Cart()
        {
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
