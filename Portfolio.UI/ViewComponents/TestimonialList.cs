using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
	public class TestimonialList : ViewComponent
	{
		private readonly IUnitOfWork _unitOfWork;
		public TestimonialList(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IViewComponentResult Invoke()
		{
			var values = _unitOfWork.Testimonial.GetAll();
			return View(values);
		}
	}
}
