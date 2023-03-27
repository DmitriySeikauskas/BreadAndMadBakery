﻿using Bakery.Models;
using Bakery.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new[] 
            {
                new Product("product 1", 1_300),
                new Product("product 2", 45),
                new Product("product 3", 1_650),
            };

            var model = new Home(products);
            
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}