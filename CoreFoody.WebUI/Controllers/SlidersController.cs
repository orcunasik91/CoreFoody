using AutoMapper;
using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DtoLayer.Dtos.SliderDtos;
using CoreFoody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.Controllers;
public class SlidersController : Controller
{
    private readonly ISliderService _sliderService;
    private readonly IMapper _mapper;

    public SlidersController(ISliderService sliderService, IMapper mapper)
    {
        _sliderService = sliderService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult SliderList()
    {
        var sliders = _sliderService.GetAll();
        List<ResultSliderDto> slidersDto = _mapper.Map<List<ResultSliderDto>>(sliders);
        return View(slidersDto);
    }

    [HttpGet]
    public IActionResult CreateSlider()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateSlider(CreateSliderDto createSliderDto)
    {
        Slider slider = _mapper.Map<Slider>(createSliderDto);
        _sliderService.Insert(slider);
        return RedirectToAction(nameof(SliderList));
    }

    public IActionResult RemoveSlider(int id)
    {
        _sliderService.Delete(id);
        return RedirectToAction(nameof(SliderList));
    }

    [HttpGet]
    public IActionResult UpdateSlider(int id)
    {
        Slider slider = _sliderService.GetById(id);
        UpdateSliderDto sliderDto = _mapper.Map<UpdateSliderDto>(slider);
        return View(sliderDto);
    }
    [HttpPost]
    public IActionResult UpdateSlider(UpdateSliderDto sliderDto)
    {
        Slider slider = _mapper.Map<Slider>(sliderDto);
        _sliderService.Update(slider);
        return RedirectToAction(nameof(SliderList));
    }
}