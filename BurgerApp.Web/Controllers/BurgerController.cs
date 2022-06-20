using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Web.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
