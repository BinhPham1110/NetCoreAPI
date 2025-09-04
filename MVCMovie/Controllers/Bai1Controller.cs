using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCMovie.Controllers
{
    public class Bai1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, int year)
        {
            int age = DateTime.Now.Year - year;
            ViewBag.Name = name;
            ViewBag.Age = age;
            return View();
        }
    }
}
