using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;
using Portfolio.BLL.Repository;
using Portfolio.MODEL.Concrete;

namespace Portfolio.UI.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public FeatureController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _unitOfWork.Feature.GetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            _unitOfWork.Feature.Update(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
