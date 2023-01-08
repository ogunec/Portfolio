using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
