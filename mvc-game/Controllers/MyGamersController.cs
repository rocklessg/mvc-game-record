using System.Web.Mvc;

namespace mvc_game.Controllers
{
    public class MyGamersController : Controller
    {
        // GET: MyGamers
        public ActionResult GamerIndex()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Al-amin";
            return View();
        }
    }
}