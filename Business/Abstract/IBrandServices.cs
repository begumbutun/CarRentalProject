using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandServices
    {
       IDataResult<List<Brand>> GetAll();
       IDataResult<Brand> GetBrandId(int brandId);
       IDataResult<Brand> GetBrandName(string brandName);

        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);

        

    }
}
