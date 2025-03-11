using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;  

namespace MvcMovie.Controllers
{
    public class ScoreController : Controller
{
    // GET: Score
    public ActionResult Index()
    {
        return View();
    }

    // POST: Score
    [HttpPost]
    public ActionResult Index(ScoreModel model)
    {
        if (ModelState.IsValid)
        {
            model.TotalScore = model.A + model.B + model.C;
            ViewBag.TotalScore = model.TotalScore;
        }

        return View(model);
    }
}

}