using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> products;
        public InMemoryCarDal()
        {
            products = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=7,DailyPrice=200,ModelYear=2010,Description="Mercedes" },
                new Car{Id=2,BrandId=1,ColorId=8,DailyPrice=300,ModelYear=2005,Description="Audi"},
                new Car{Id=3,BrandId=5,ColorId=6,DailyPrice=400,ModelYear=2012,Description="BMW" },
                new Car{Id=4,BrandId=3,ColorId=3,DailyPrice=500,ModelYear=2020,Description="Opel" },
                new Car{Id=5,BrandId=7,ColorId=1,DailyPrice=600,ModelYear=2019,Description="Toyota" },
            };
        }
        public void Add(Car car)
        {
            products.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = products.SingleOrDefault(p => p.Id == car.Id);

            products.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return products;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return products.Where(p => p.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = products.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
