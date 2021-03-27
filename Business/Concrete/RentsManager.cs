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
    public class RentsManager : IRentsService
    {
        IRentsDal _rentsDal;

        public RentsManager(IRentsDal rentsDal)
        {
            _rentsDal = rentsDal;
        }
        public IResult Add(Rents rents)
        {
            _rentsDal.Add(rents);
            if(rents.ReturnDate != rents.ReturnDate)
            {
                return new ErrorResult(Messages.NameInvalid);
            }
            _rentsDal.Add(rents);
            return new SuccessResult(Messages.RentsAdded);

        }

        public IResult Delete(Rents rents)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rents>> GetAll()
        {
            return new SuccessDataResult<List<Rents>>(_rentsDal.GetAll());
        }

        public IResult Update(Rents rents)
        {
            throw new NotImplementedException();
        }
    }
}
