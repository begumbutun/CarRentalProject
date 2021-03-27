using Core.Utilities.Results;
using Entities.Concrete.CarImages;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImagesServices
    {
        IDataResult<List<CarImages>> GetAll();
        IResult Add(CarImages carImages, IFormFile formFile);
        IResult Update(CarImages carImages, IFormFile formFile);
        IResult Delete(CarImages carImages);
    }
}
