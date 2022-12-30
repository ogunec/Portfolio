using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
