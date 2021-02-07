using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Description.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("araç eklendi");
            }
            
        }

        public void Delete(int id)
        {
            foreach (var carid in _carDal.GetAll())
            {
                if(carid.Id == id)
                {
                     _carDal.Delete(carid);
                     Console.WriteLine("silindi");

                }
            }
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();


        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(p => p.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public void Update(int id,Car car)
        {
            foreach (var _car in _carDal.GetAll())
            {
                if (_car.Id == id)
                {
                    _car.Id = car.Id;
                    _car.ColorId = car.ColorId;
                    _car.BrandId = car.BrandId;
                    _car.ModelYear = car.ModelYear;
                    _car.DailyPrice = car.DailyPrice;
                    _car.Description = car.Description;
                    Console.WriteLine("güncellendi");

                }
            }
        }
    }
}
