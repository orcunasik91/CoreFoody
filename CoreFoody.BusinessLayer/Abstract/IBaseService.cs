namespace CoreFoody.BusinessLayer.Abstract;
public interface IBaseService<TEntity> where TEntity : class
{
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
    List<TEntity> GetAll();
    TEntity GetById(int id);
}