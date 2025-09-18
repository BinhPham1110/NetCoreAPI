using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MVCMovie.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /Employee/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Employee/Welcome
        public string Welcome()
        {
            return "Chào các bạn tớ tên là Bình , đây là Employee Controller  ";
        }
       
    }
}