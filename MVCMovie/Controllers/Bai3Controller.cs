using Microsoft.AspNetCore.Mvc;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double height, double weight)
        {
            BMI model = new BMI();
            model.Height = height;
            model.Weight = weight;
            model.Result = weight / (height * height);

            if (model.Result < 18.5)
                model.Status = "Gầy";
            else if (model.Result < 24.9)
                model.Status = "Bình thường";
            else if (model.Result < 29.9)
                model.Status = "Thừa cân";
            else
                model.Status = "Béo phì";

            return View(model);
        }
    }
}
