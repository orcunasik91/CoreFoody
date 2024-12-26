using AutoMapper;
using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DtoLayer.Dtos.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.ViewComponents.HomePageLayoutViewComponents;
public class _AboutSectionComponentPartial : ViewComponent
{
    private readonly IAboutService _aboutService;
    private readonly IMapper _mapper;

    public _AboutSectionComponentPartial(IAboutService aboutService, IMapper mapper)
    {
        _aboutService = aboutService;
        _mapper = mapper;
    }

    public IViewComponentResult Invoke()
    {
        var abouts = _aboutService.GetAll();
        List<ResultAboutDto> aboutsDto = _mapper.Map<List<ResultAboutDto>>(abouts);
        return View(aboutsDto);
    }
}