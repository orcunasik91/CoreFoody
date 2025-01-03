﻿using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class SliderManager : ISliderService
{
    private readonly ISliderDal _sliderDal;

    public SliderManager(ISliderDal sliderDal)
    {
        _sliderDal = sliderDal;
    }

    public void Delete(int id)
    {
        _sliderDal.Delete(id);
    }

    public List<Slider> GetAll()
    {
        return _sliderDal.GetAll();
    }

    public Slider GetById(int id)
    {
        return _sliderDal.GetById(id);
    }

    public void Insert(Slider entity)
    {
        _sliderDal.Insert(entity);
    }

    public void Update(Slider entity)
    {
        _sliderDal.Update(entity);
    }
}