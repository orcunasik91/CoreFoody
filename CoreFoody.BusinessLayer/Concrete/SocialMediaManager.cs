using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class SocialMediaManager : ISocialMediaService
{
    private readonly ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public void Delete(int id)
    {
        _socialMediaDal.Delete(id);
    }

    public List<SocialMedia> GetAll()
    {
        return _socialMediaDal.GetAll();
    }

    public SocialMedia GetById(int id)
    {
        return _socialMediaDal.GetById(id);
    }

    public void Insert(SocialMedia entity)
    {
        _socialMediaDal.Insert(entity);
    }

    public void Update(SocialMedia entity)
    {
        _socialMediaDal.Update(entity);
    }
}