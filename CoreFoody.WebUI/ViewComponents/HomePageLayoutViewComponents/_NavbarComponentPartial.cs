using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _NavbarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}