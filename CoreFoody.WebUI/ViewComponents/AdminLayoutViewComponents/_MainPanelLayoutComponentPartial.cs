using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.AdminLayoutViewComponents;
public class _MainPanelLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}