using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
	public class ExperienceList : ViewComponent
	{
		private readonly IUnitOfWork _unitOfWork;
		public ExperienceList(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IViewComponentResult Invoke()
		{
			var values = _unitOfWork.Experience.GetAll();
			return View(values);
		}
	}
}
