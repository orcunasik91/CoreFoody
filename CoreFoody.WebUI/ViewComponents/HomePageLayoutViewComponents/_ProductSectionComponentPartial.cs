using CoreFoody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _ProductSectionComponentPartial : ViewComponent
{
    private readonly IProductService _productService;

    public _ProductSectionComponentPartial(IProductService productService)
    {
        _productService = productService;
    }

    public IViewComponentResult Invoke()
    {
        var productsLast12Items = _productService.ProductsWithCategoryAndLast12Items();
        return View(productsLast12Items);
    }
}