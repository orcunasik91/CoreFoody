using AutoMapper;
using CoreFoody.DtoLayer.Dtos.AboutDtos;
using CoreFoody.DtoLayer.Dtos.SliderDtos;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.WebUI.Mappings;
public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        #region AboutMapping
        CreateMap<ResultAboutDto, About>().ReverseMap();
        CreateMap<CreateAboutDto, About>().ReverseMap();
        CreateMap<UpdateAboutDto, About>().ReverseMap();
        CreateMap<GetAboutDto, About>().ReverseMap();
        #endregion
        #region SliderMapping
        CreateMap<ResultSliderDto, Slider>().ReverseMap();
        CreateMap<CreateSliderDto, Slider>().ReverseMap();
        CreateMap<UpdateSliderDto, Slider>().ReverseMap();
        CreateMap<GetSliderDto, Slider>().ReverseMap();
        #endregion
    }
}