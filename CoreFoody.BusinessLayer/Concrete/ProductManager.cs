using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Delete(int id)
    {
        _productDal.Delete(id);
    }

    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }

    public Product GetById(int id)
    {
        return _productDal.GetById(id);
    }

    public void Insert(Product entity)
    {
        _productDal.Insert(entity);
    }

    public List<Product> ProductsWithCategory()
    {
        return _productDal.ProductListWithCategory();
    }

    public List<Product> ProductsWithCategoryAndLast12Items()
    {
        return _productDal.ProductListWithCategoryAndLast12Items();
    }

    public void Update(Product entity)
    {
        _productDal.Update(entity);
    }
}