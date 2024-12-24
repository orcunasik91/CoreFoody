using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Abstract;
public interface IProductService : IBaseService<Product>
{
    List<Product> ProductsWithCategory();
}