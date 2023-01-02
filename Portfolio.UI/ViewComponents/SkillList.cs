using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
    public class SkillList : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public SkillList(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.Skill.GetAll();
            return View(values);
        }
    }
}
