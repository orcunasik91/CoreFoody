namespace CoreFoody.DataAccessLayer.Abstract;
public interface IRepositoryDal<T> where T : class, new()
{
    void Insert(T entity);
    void Update(T entity);
    void Delete(int id);
    List<T> GetAll();
    T GetById(int id);
}