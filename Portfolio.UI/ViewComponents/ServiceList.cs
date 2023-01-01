using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
    public class ServiceList : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceList(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.Service.GetAll();
            return View(values);
        }
    }
}
