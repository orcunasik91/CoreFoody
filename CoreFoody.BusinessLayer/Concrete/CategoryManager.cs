using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void Insert(Category entity)
    {
        _categoryDal.Insert(entity);
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }
}