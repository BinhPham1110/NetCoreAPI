namespace MVCMovie.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MVCMovie.Models;

    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Dữ liệu từ controller gửi về view ";
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            ViewBag.Message = ps.StudentID + "-" + ps.FullName;
            return View();
        }
    }
}