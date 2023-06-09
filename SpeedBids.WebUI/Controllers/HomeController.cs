﻿using Microsoft.AspNetCore.Mvc;
using SpeedBids.Data;
using SpeedBids.Entities;
using SpeedBids.WebUI.Models;
using System.Diagnostics;

namespace SpeedBids.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SpeedBidsDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, SpeedBidsDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Product> products = _dbContext.Products.ToList();

            return View(products);
        }

        public IActionResult Privacy()
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