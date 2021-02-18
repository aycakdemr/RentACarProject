using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            //business code
             _carDal.Add(car);
            return new SuccessResult(Messages.added);
    
        }

        public IResult Delete(int id)
        {
            foreach (var carid in _carDal.GetAll())
            {
                if(carid.Id == id)
                {
                     _carDal.Delete(carid);
                    return new SuccessResult(Messages.deleted);

                }
            }
             return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.listed);


        }

        public IDataResult<List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.succeed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.succeed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id), Messages.succeed);
        }

        public IResult Update(int id,Car car)
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
                    return new SuccessResult(Messages.updated);

                }
            }
            return new SuccessResult(Messages.error);
        }
    }
}
