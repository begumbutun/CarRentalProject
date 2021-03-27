using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
      IDataResult<List<Car>> GetAll();
       IDataResult<Car>GetCarsById(int carId);
        IDataResult<Car> GetCarsByBrandId(int brandId);
        IDataResult<Car> GetCarsByColorId(int colorId);
        IDataResult<Car> GetCarsByModelYear(int modelYear);
        IDataResult<Car> GetCarsDescriptions(string descriptions);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

       IDataResult<List<CarDetailDto>> GetCarDetails();


    }
}