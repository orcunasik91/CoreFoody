using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfAboutDal : BaseRepository<About>, IAboutDal
{
    public EfAboutDal(FoodyDbContext context) : base(context)
    {
    }
}