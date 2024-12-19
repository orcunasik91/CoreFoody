using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }

    public void Delete(int id)
    {
        _featureDal.Delete(id);
    }

    public List<Feature> GetAll()
    {
        return _featureDal.GetAll();
    }

    public Feature GetById(int id)
    {
        return _featureDal.GetById(id);
    }

    public void Insert(Feature entity)
    {
        _featureDal.Insert(entity);
    }

    public void Update(Feature entity)
    {
        _featureDal.Update(entity);
    }
}