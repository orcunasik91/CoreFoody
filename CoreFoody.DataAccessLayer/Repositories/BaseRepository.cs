using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;

namespace CoreFoody.DataAccessLayer.Repositories;
public class BaseRepository<T> : IRepositoryDal<T> where T : class, new()
{
    private readonly FoodyDbContext _context;

    public BaseRepository(FoodyDbContext context)
    {
        _context = context;
    }

    public void Delete(int id)
    {
        T entity = _context.Set<T>().Find(id);
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Insert(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }
}