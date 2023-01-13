using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExperienceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var values = _unitOfWork.Experience.GetAll();
            return View(values);
        }
    }
}
