using CoreFoody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _AboutItemComponentPartial : ViewComponent
{
    private readonly IAboutItemService _aboutItemService;

    public _AboutItemComponentPartial(IAboutItemService aboutItemService)
    {
        _aboutItemService = aboutItemService;
    }

    public IViewComponentResult Invoke()
    {
        var aboutItems = _aboutItemService.GetAll();
        return View(aboutItems);
    }
}