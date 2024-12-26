using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class AboutItemManager : IAboutItemService
{
    private readonly IAboutItemDal _aboutItemDal;

    public AboutItemManager(IAboutItemDal aboutItemDal)
    {
        _aboutItemDal = aboutItemDal;
    }

    public void Delete(int id)
    {
        _aboutItemDal.Delete(id);
    }

    public List<AboutItem> GetAll()
    {
        return _aboutItemDal.GetAll();
    }

    public AboutItem GetById(int id)
    {
        return _aboutItemDal.GetById(id);
    }

    public void Insert(AboutItem entity)
    {
        _aboutItemDal.Insert(entity);
    }

    public void Update(AboutItem entity)
    {
        _aboutItemDal.Update(entity);
    }
}