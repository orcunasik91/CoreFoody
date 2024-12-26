using CoreFoody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _FeatureSectionComponentPartial : ViewComponent
{
    private readonly IFeatureService _featureService;

    public _FeatureSectionComponentPartial(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    public IViewComponentResult Invoke()
    {
        var features = _featureService.GetAll();
        return View(features);
    }
}