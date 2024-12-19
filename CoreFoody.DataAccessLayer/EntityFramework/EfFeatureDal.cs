using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfFeatureDal : BaseRepository<Feature>, IFeatureDal
{
    public EfFeatureDal(FoodyDbContext context) : base(context)
    {
    }
}