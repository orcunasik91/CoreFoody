using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfReviewDal : BaseRepository<Review>, IReviewDal
{
    public EfReviewDal(FoodyDbContext context) : base(context)
    {
    }
}