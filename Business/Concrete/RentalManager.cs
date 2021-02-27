using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentaldal)
        {
            _rentalDal = rentaldal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental t)
        {
            if(t.ReturnDate != null)
            {
                 _rentalDal.Add(t);
                 return new SuccessResult("kiralandı");
            }
            return new SuccessResult("araba kiralamak için önce teslim edilmesi gerekir");
            
        }

        public IResult Delete(int id)
        {
            foreach (var rentalid in _rentalDal.GetAll())
            {
                if (rentalid.Id == id)
                {
                    _rentalDal.Delete(rentalid);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.listed);
        }

        public IDataResult<List<Rental>> GetById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IResult Update(int id, Rental t)
        {
            foreach (var _rental in _rentalDal.GetAll())
            {
                if (_rental.Id == id)
                {
                    _rental.CarId = t.CarId;
                    _rental.CustomerId = t.CustomerId;
                    _rental.RentDate = t.RentDate;
                    _rental.ReturnDate = t.ReturnDate;

                    return new SuccessResult(Messages.updated);

                }
            }
            return new SuccessResult(Messages.error);
        }
    }
}
