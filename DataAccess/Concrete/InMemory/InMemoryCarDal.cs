using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 1999,  Descriptions = "En az iki gün kiralanır."},
                new Car {Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2010,  Descriptions = "En az üç gün kiralanır."},
                new Car {Id = 3, BrandId = 1, ColorId = 2, ModelYear = 2019,  Descriptions = "En az bir haftalık kiralanır."},
                new Car {Id = 4, BrandId = 2, ColorId = 2, ModelYear = 1999,  Descriptions = "En az iki gün kiralanır."},
                new Car {Id = 5, BrandId = 2, ColorId = 1, ModelYear = 2016,  Descriptions = "En az üç gün kiralanır."},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            // LINQ kullanıyoruz.
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> Update()
        {
           
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.BrandId == car.BrandId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.Id = car.Id;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}