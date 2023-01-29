using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Repository;

namespace Portfolio.UI.Controllers
{
    public class FeatureController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public FeatureController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _unitOfWork.Feature.GetById(1);
            return View(values);
        }
    }
}
