using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PortfolioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var values = _unitOfWork.MyPortfolio.GetAll();
            return View(values);
        }
    }
}
