using System.Web.Mvc;

namespace MealPlan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Diary");
        }
    }
}