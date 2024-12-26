using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _HeadSectionComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}