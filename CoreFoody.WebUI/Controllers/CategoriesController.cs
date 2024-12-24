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
    [HttpGet]
    public IActionResult CategoryList()
    {
        List<Category> categories = _categoryService.GetAll();
        return View(categories);
    }
    [HttpGet]
    public IActionResult CreateCategory()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        _categoryService.Insert(category);
        return RedirectToAction(nameof(CategoryList));
    }
    public IActionResult RemoveCategory(int id)
    {
        _categoryService.Delete(id);
        return RedirectToAction(nameof(CategoryList));
    }
    [HttpGet]
    public IActionResult UpdateCategory(int id)
    {
        Category category = _categoryService.GetById(id);
        return View(category);
    }
    [HttpPost]
    public IActionResult UpdateCategory(Category category)
    {
        _categoryService.Update(category);
        return RedirectToAction(nameof(CategoryList));
    }
}