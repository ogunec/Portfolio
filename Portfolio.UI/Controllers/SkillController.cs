using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.Controllers
{
    public class SkillController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SkillController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var values = _unitOfWork.Skill.GetAll();
            return View(values);
        }
    }
}
