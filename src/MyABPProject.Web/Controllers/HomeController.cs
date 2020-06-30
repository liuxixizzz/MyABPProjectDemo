using Microsoft.AspNetCore.Mvc;

namespace MyABPProject.Web.Controllers
{
    public class HomeController : MyABPProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}