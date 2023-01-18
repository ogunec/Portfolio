using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;
using Portfolio.MODEL.Concrete;

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
        [HttpGet]
        public IActionResult AddExperience()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience exp)
        {
            _unitOfWork.Experience.Add(exp);
            return RedirectToAction("Index","Experience");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            Experience selectedExperience = _unitOfWork.Experience.GetById(id);
            return View(selectedExperience);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience exp)
        {
            _unitOfWork.Experience.Update(exp);
            return RedirectToAction("Index","Experience");
        }
        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            Experience selectedExperience = _unitOfWork.Experience.GetById(id);
            return View(selectedExperience);
        }
        [HttpPost]
        public IActionResult DeleteExperience(Experience exp)
        {
            _unitOfWork.Experience.Delete(exp);
            return RedirectToAction("Index", "Experience");
        }
    }
}
