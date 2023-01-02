using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
	public class PortfolioList : ViewComponent
	{
		private readonly IUnitOfWork _unitOfWork;

        public PortfolioList(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IViewComponentResult Invoke()
		{
			var values = _unitOfWork.MyPortfolio.GetAll();
			return View(values);
		}
	}
}
