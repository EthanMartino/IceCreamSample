using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IceCreamSample.Controllers
{
    public class ModelBindingHomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IceCream ice)
        {
            if (ModelState.IsValid)
            {
                //add to db
                IceCreamDB.Add(ice);
                
                return RedirectToAction("Index", "Success");
            }
            else
            {
                return View(ice);
            }
        }
    }
}