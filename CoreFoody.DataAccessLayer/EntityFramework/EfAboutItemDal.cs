using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfAboutItemDal : BaseRepository<AboutItem>, IAboutItemDal
{
    public EfAboutItemDal(FoodyDbContext context) : base(context)
    {
    }
}