using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;
using Portfolio.MODEL.Concrete;

namespace Portfolio.UI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AboutController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _unitOfWork.About.GetById(3);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            _unitOfWork.About.Update(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
