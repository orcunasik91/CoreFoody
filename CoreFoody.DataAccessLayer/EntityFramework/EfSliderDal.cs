using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfSliderDal : BaseRepository<Slider>, ISliderDal
{
    public EfSliderDal(FoodyDbContext context) : base(context)
    {
    }
}