using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;
using Portfolio.MODEL.Concrete;

namespace Portfolio.UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DefaultController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.Date = DateTime.Now;
            message.Status = true;
            _unitOfWork.Message.Add(message);
            return RedirectToAction("Index", "Default");
        }
    }
}
