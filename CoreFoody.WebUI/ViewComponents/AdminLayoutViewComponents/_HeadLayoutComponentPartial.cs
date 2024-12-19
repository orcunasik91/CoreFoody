using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _HeadLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
