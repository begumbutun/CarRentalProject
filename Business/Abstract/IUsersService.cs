using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IDataResult<List<User>> GetAll();
        IResult Add( User users);
        IResult Update(User users);
        IResult Delete(User users);
    }
}
