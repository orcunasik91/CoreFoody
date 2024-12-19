using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfProductDal : BaseRepository<Product>, IProductDal
{
    public EfProductDal(FoodyDbContext context) : base(context)
    {
    }
}