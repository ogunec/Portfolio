using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;
using Portfolio.MODEL.Concrete;

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
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _unitOfWork.Skill.Add(skill);
            return RedirectToAction("Index","Skill");
        }

        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            var SkillFromDb = _unitOfWork.Skill.GetById(id);
            return View(SkillFromDb);
        }
        [HttpPost]
        public IActionResult DeleteSkill(Skill obj)
        {
            _unitOfWork.Skill.Delete(obj);
            return RedirectToAction("Index", "Skill");
        }
    }
}
