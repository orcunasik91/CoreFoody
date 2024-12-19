using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.Controllers;
public class CategoriesController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IActionResult CategoryList()
    {
        List<Category> categories = _categoryService.GetAll();
        return View(categories);
    }
}