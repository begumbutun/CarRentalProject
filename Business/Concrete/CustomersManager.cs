using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomersManager : ICustomersService
    {
        ICustomerDal _customerDal;

        public CustomersManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customers customers)
        {
            _customerDal.Add(customers);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Customers customers)
        {
            _customerDal.Delete(customers);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll());
        }

        public IResult Update(Customers customers)
        {
            _customerDal.Update(customers);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
