using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.AdminLayoutViewComponents;
public class _SidebarLayoutComponentPartial : ViewComponent
{
    public  IViewComponentResult Invoke()
    {
        return View();
    }
}