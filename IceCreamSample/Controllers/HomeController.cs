using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IceCreamSample.Models;
using Microsoft.AspNetCore.Http;

namespace IceCreamSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection data)
        {
            IceCream ice = new IceCream();
            ice.Flavor = data["flavor"];
            try
            {
                ice.Scoops = Convert.ToByte(data["scoops"]);
            }
            catch (Exception)
            {
                throw new Exception();
            }
            ice.Container = data["container"];

            //Add to db
            IceCreamDB.Add(ice);

            ViewData["Success"] = "Order Complete!";

            return View();
        }

        public IActionResult Privacy()
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
