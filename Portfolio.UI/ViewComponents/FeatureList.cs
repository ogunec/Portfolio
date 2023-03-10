using Microsoft.AspNetCore.Mvc;
using Portfolio.BLL.Abstract;

namespace Portfolio.UI.ViewComponents
{
    public class FeatureList : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public FeatureList(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.Feature.GetAll();
            return View(values);
        }
    }
}
