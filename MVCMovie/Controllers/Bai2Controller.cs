using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class Bai2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double a, double b, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "sum":
                    result = a + b;
                    break;
                case "sub":
                    result = a - b;
                    break;
                case "mul":
                    result = a * b;
                    break;
                case "div":
                    result = b != 0 ? a / b : double.NaN;
                    break;
            }

            ViewBag.Result = result;
            return View();
        }
    }
}
