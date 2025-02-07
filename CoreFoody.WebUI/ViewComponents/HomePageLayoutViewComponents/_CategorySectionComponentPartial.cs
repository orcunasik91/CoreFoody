using CoreFoody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _CategorySectionComponentPartial : ViewComponent
{
    ICategoryService _categoryService;

    public _CategorySectionComponentPartial(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    public IViewComponentResult Invoke()
    {
        var categories = _categoryService.GetAll();
        return View(categories);
    }
}