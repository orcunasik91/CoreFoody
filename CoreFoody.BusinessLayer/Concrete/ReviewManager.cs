using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class ReviewManager : IReviewService
{
    private readonly IReviewDal _reviewDal;

    public ReviewManager(IReviewDal reviewDal)
    {
        _reviewDal = reviewDal;
    }

    public void Delete(int id)
    {
        _reviewDal.Delete(id);
    }

    public List<Review> GetAll()
    {
        return _reviewDal.GetAll();
    }

    public Review GetById(int id)
    {
        return _reviewDal.GetById(id);
    }

    public void Insert(Review entity)
    {
        _reviewDal.Insert(entity);
    }

    public void Update(Review entity)
    {
        _reviewDal.Update(entity);
    }
}