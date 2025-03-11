using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class InvoiceController : Controller
    {
        
        public IActionResult Index()
        {
           
            ViewBag.infoPerson = "Nhập số lượng và đơn giá để tính tiền hóa đơn";
            return View();
        }

 
        [HttpPost]
        public IActionResult Index(Invoice model)
        {
       
            if (model.Quantity > 0 && model.UnitPrice > 0)
            {
        
                model.TotalAmount = model.Quantity * model.UnitPrice;

               
                ViewBag.infoPerson = $"Tổng tiền hóa đơn: {model.TotalAmount:C2}";  
            }
            else
            {
             
                ViewBag.infoPerson = "Dữ liệu không hợp lệ. Vui lòng nhập lại.";
            }

        
            return View(model);
        }
    }
}

