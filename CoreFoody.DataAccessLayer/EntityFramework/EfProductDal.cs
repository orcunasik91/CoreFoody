using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.Repositories;
using CoreFoody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreFoody.DataAccessLayer.EntityFramework;
public class EfProductDal : BaseRepository<Product>, IProductDal
{
    private readonly FoodyDbContext _context;
    public EfProductDal(FoodyDbContext context) : base(context)
    {
        _context = context;
    }

    public List<Product> ProductListWithCategory()
    {
        List<Product> products = _context.Products.Include(p => p.Category).ToList();
        return products;
    }

    public List<Product> ProductListWithCategoryAndLast12Items()
    {
        List<Product> products = _context.Products.OrderByDescending(p => p.ProductId).Take(12).Include(p => p.Category).ToList();
        return products;
    }
}