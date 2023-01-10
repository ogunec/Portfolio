using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult SidebarPartial()
		{
			return PartialView();
		}

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
