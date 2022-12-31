using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
	public class AboutList : ViewComponent
	{
        private readonly IUnitOfWork _unitOfWork;
        public AboutList(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.About.GetAll();
            return View(values);
        }
    }
}
