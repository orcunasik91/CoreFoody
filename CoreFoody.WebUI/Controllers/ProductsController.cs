using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreFoody.WebUI.Controllers;
public class ProductsController : Controller
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public ProductsController(IProductService productService, ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }
    [HttpGet]
    public IActionResult ProductList()
    {
        List<Product> products = _productService.GetAll();
        return View(products);
    }
    [HttpGet]
    public IActionResult ProductListWithCategory()
    {
        List<Product> productsWithCategory = _productService.ProductsWithCategory();
        return View(productsWithCategory);
    }
    [HttpGet]
    public IActionResult CreateProduct()
    {
        List<Category> categories = _categoryService.GetAll();
        ViewBag.CategorList = new SelectList(categories,"CategoryId","CategoryName");
        return View();
    }
    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        _productService.Insert(product);
        return RedirectToAction(nameof(ProductListWithCategory));
    }
    public IActionResult RemoveProduct(int id)
    {
        _productService.Delete(id);
        return RedirectToAction(nameof(ProductListWithCategory));
    }
    [HttpGet]
    public IActionResult UpdateProduct(int id)
    {
        Product product = _productService.GetById(id);
        List<Category> categories = _categoryService.GetAll();
        ViewBag.CategorList = new SelectList(categories, "CategoryId", "CategoryName");
        return View(product);
    }
    [HttpPost]
    public IActionResult UpdateProduct(Product product)
    {
        _productService.Update(product);
        return RedirectToAction(nameof(ProductListWithCategory));
    }

}