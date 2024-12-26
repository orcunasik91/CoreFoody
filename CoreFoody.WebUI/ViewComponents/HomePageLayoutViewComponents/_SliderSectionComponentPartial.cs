using AutoMapper;
using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DtoLayer.Dtos.SliderDtos;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _SliderSectionComponentPartial : ViewComponent
{
    private readonly ISliderService _sliderService;
    private readonly IMapper _mapper;

    public _SliderSectionComponentPartial(ISliderService sliderService, IMapper mapper)
    {
        _sliderService = sliderService;
        _mapper = mapper;
    }

    public IViewComponentResult Invoke()
    {
        var sliders = _sliderService.GetAll();
        List<ResultSliderDto> slidersDto = _mapper.Map<List<ResultSliderDto>>(sliders);
        return View(slidersDto);
    }
}