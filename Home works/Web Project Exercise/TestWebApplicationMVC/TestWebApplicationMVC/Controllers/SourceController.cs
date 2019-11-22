using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApplicationMVC.Controllers
{
    public class SourceController : Controller
    {
        public IActionResult Hello()
        {
            ViewBag.Rand = new Random().Next(1, 101);

            return View();
        }
        public dynamic Hi()
        {
            return new
            {
                counter = 1,
                useres = new string[] {"Ivan", "Cecilia"}
            };
        }
    }
}