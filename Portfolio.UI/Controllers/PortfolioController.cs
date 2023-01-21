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
            if (ModelState.IsValid)
            {
                _unitOfWork.MyPortfolio.Add(portfolio);
                return RedirectToAction("Index", "Portfolio");
            }
            else
            {
                return View();
            }
            
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            MyPortfolio SelectedPortfolio = _unitOfWork.MyPortfolio.GetById(id);
            return View(SelectedPortfolio);
        }
        [HttpPost]
        public IActionResult EditPortfolio(MyPortfolio portfolio)
        {
            _unitOfWork.MyPortfolio.Update(portfolio);
            return RedirectToAction("Index", "Portfolio");
        }
        [HttpGet]
        public IActionResult DeletePortfolio(int id)
        {
            MyPortfolio SelectedPortfolio = _unitOfWork.MyPortfolio.GetById(id);
            return View(SelectedPortfolio);
        }
        [HttpPost]
        public IActionResult DeletePortfolio(MyPortfolio portfolio)
        {
            _unitOfWork.MyPortfolio.Delete(portfolio);
            return RedirectToAction("Index", "Portfolio");
        }
    }
}
