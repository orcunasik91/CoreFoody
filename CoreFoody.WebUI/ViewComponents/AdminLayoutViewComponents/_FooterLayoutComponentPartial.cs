using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.AdminLayoutViewComponents;
public class _FooterLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}