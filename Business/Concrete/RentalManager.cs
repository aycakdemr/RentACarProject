using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
             _rentalDal.Add(t);
             return new SuccessResult("kiralandı");
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
        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.succeed);
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
        public Boolean IsRentable(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);

            if (result.Any(r =>
                r.RentEndDate >= rental.RentStartDate &&
                r.RentStartDate <= rental.RentEndDate
            )) return true;

            return false;
        }
    }
}
