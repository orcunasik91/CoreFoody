using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.DataAccessLayer.Abstract;
public interface IProductDal : IRepositoryDal<Product>
{
    List<Product> ProductListWithCategory();
    List<Product> ProductListWithCategoryAndLast12Items();
}