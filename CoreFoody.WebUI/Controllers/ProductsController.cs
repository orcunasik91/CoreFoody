using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.Controllers;
public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
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
}