using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfSocialMediaDal : BaseRepository<SocialMedia>, ISocialMediaDal
{
    public EfSocialMediaDal(FoodyDbContext context) : base(context)
    {
    }
}