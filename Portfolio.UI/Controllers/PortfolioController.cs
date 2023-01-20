using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;
using Portfolio.MODEL.Concrete;

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
        [HttpGet]
        public IActionResult AddPortfolio() 
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult AddPortfolio(MyPortfolio portfolio)
        {
            _unitOfWork.MyPortfolio.Add(portfolio);
            return RedirectToAction("Index","Portfolio");
        }
    }
}
