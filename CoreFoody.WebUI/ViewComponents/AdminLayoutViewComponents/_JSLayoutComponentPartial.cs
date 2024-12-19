using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.AdminLayoutViewComponents;
public class _JSLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}