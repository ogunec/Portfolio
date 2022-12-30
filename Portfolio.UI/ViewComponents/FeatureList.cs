using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.ViewComponents
{
    public class FeatureList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
