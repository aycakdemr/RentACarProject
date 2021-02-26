using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImage)
        {
            _carImageDal = carImage;
        }

        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageCountOfMoreThanFive());
            if (result != null)
            {
                return result;
            }
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var carImageId in _carImageDal.GetAll())
            {
                if (carImageId.Id == id)
                {
                    _carImageDal.Delete(carImageId);
                    return new SuccessResult(Messages.deleted);

                }

            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.listed);
        }


        public IDataResult<List<CarImage>> GetById(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.Id == id), Messages.succeed);
        }


        public IResult Update(int id, CarImage t)
        {
            foreach (var carImageId in _carImageDal.GetAll())
            {
                if (carImageId.Id == id)
                {
                    carImageId.ImagePath = t.ImagePath;
                    carImageId.Date = t.Date;
                    return new SuccessResult(Messages.updated);

                }
            }
            return new ErrorResult(Messages.error);
        }
        private IResult CheckIfCarImageCountOfMoreThanFive()
        {

            int result = _carImageDal.GetAll().Count;
            if (result > 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }


    }
}
