using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _FooterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}