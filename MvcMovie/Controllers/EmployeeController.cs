using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();  // Trả về View Index của Employee
        }

        public IActionResult Details()
        {
            return View();  // Trả về View Details của Employee
        }
    }
}
