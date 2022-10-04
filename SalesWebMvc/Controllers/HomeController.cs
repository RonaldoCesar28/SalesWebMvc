using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMvc.Models.ViewModels; 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
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
            ViewData["Message"] = "App Web from Sales with C# and Asp.Net Core MVC ";

            return View();
        }

        public IActionResult Contact() 
        {
                        
            ViewData["email"] = "ronaldocesar28@outlook.com";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
