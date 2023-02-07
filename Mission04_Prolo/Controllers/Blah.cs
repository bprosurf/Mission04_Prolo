using Microsoft.AspNetCore.Mvc;
using Mission04_Prolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_Prolo.Controllers
{
    public class Blah : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Calculator ()
        {
            return View();
        }
         

        [HttpPost]
        public IActionResult Calculator (CalculatorModel model)
        {
            return View();
        }
    }
}
