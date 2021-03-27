using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentsService
    {
        IDataResult<List<Rents>> GetAll();
        IResult Add(Rents rents);
        IResult Update(Rents rents);
        IResult Delete(Rents rents);
    }
}
