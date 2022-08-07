﻿using Mahal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mahal.Controllers
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
            return View();
        }

        public IActionResult Photos()
        {
            return View();
        }

        public IActionResult Videos()
        {
            return View();
        }

        public IActionResult Achievements()
        {
            return View();
        }

        public IActionResult Cards()
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