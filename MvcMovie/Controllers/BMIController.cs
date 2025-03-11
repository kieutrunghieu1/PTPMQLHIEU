using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;  

namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult CalculateBMI(BMIModel model)
        {
            if (ModelState.IsValid)
            {
               
                model.BMI = model.Weight / (model.Height * model.Height);

              
                if (model.BMI < 18.5)
                {
                    model.Status = "Thiếu cân";
                }
                else if (model.BMI >= 18.5 && model.BMI <= 24.9)
                {
                    model.Status = "Bình thường";
                }
                else if (model.BMI >= 25 && model.BMI <= 29.9)
                {
                    model.Status = "Thừa cân";
                }
                else
                {
                    model.Status = "Béo phì";
                }

                
                ViewBag.BMI = model.BMI;
                ViewBag.Status = model.Status;
            }

            return View("Index");
        }
    }
}
