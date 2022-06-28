using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CustomersManager : ICustomersService
    {
        ICustomerDal _CustomerDal;

        public CustomersManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
        }

        public Customers GetByID(int id)
        {
            return _CustomerDal.GetByID(id);
        }

        public void TAdd(Customers t)
        {
            _CustomerDal.Insert(t);
        }

        public void TDelete(Customers t)
        {
            _CustomerDal.Delete(t);
        }

        public List<Customers> TGetList()
        {
            return _CustomerDal.GetList();
        }

        public void TUpdate(Customers t)
        {
            _CustomerDal.Update(t);
        }
    }
}
