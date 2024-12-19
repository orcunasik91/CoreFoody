using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfCategoryDal : BaseRepository<Category>, ICategoryDal
{
    public EfCategoryDal(FoodyDbContext context) : base(context)
    {
    }
}