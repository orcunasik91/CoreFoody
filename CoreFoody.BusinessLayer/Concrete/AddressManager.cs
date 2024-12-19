using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.EntityLayer.Concrete;

namespace CoreFoody.BusinessLayer.Concrete;
public class AddressManager : IAddressService
{
    private readonly IAddressDal _addressDal;

    public AddressManager(IAddressDal addressDal)
    {
        _addressDal = addressDal;
    }

    public void Delete(int id)
    {
        _addressDal.Delete(id);
    }

    public List<Address> GetAll()
    {
        return _addressDal.GetAll();
    }

    public Address GetById(int id)
    {
        return _addressDal.GetById(id);
    }

    public void Insert(Address entity)
    {
        _addressDal.Insert(entity);
    }

    public void Update(Address entity)
    {
        _addressDal.Update(entity);
    }
}