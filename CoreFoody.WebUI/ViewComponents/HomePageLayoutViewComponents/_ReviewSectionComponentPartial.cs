using AutoMapper;
using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DtoLayer.Dtos.ReviewDtos;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _ReviewSectionComponentPartial : ViewComponent
{
    private readonly IReviewService reviewService;
    private readonly IMapper mapper;

    public _ReviewSectionComponentPartial(IReviewService _reviewService, IMapper _mapper)
    {
        reviewService = _reviewService;
        mapper = _mapper;
    }

    public IViewComponentResult Invoke()
    {
        var reviews = reviewService.GetAll();
        List<ResultReviewDto> customerComments = mapper.Map<List<ResultReviewDto>>(reviews);
        return View(customerComments);
    }
}