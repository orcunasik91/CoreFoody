using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _StylesComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}