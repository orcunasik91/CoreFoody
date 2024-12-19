using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfAddressDal : BaseRepository<Address>, IAddressDal
{
    public EfAddressDal(FoodyDbContext context) : base(context)
    {
    }
}