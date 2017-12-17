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

        [HttpGet("shop")]
        public IActionResult Shop()
        {
            return View();
        }

        [HttpGet("cart")]
        public IActionResult Cart()
        {
            return View();
        }
        
    }
}
