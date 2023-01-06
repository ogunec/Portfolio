using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
