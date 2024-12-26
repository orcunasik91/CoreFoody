using AutoMapper;
using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DtoLayer.Dtos.AboutDtos;
using CoreFoody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.Controllers;
public class AboutController : Controller
{
    private readonly IAboutService _aboutService;
    private readonly IMapper _mapper;

    public AboutController(IAboutService aboutService, IMapper mapper)
    {
        _aboutService = aboutService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var about = _aboutService.GetAll();
        List<ResultAboutDto> aboutDto = _mapper.Map<List<ResultAboutDto>>(about);
        return View(aboutDto);
    }
    [HttpGet]
    public IActionResult CreateAbout()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateAbout(CreateAboutDto aboutDto)
    {
        About about = _mapper.Map<About>(aboutDto);
        _aboutService.Insert(about);
        return RedirectToAction(nameof(Index));
    }
    
    public IActionResult RemoveAbout(int id)
    {
        _aboutService.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult UpdateAbout(int id)
    {
        About about = _aboutService.GetById(id);
        UpdateAboutDto aboutDto = _mapper.Map<UpdateAboutDto>(about);
        return View(aboutDto);
    }
    [HttpPost]
    public IActionResult UpdateAbout(UpdateAboutDto aboutDto)
    {
        About about = _mapper.Map<About>(aboutDto);
        _aboutService.Update(about);
        return RedirectToAction(nameof(Index));
    }
}