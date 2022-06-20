using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
