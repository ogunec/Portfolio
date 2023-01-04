using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
    public class ContactDetails : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContactDetails(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.Contact.GetAll();
            return View(values);
        }
    }
}
