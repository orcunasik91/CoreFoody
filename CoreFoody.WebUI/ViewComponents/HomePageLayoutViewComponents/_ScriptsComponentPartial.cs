using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _ScriptsComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}