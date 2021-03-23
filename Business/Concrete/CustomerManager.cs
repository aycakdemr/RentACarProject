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
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal  _customerdal;
        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer t)
        {
            _customerdal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var customerid in _customerdal.GetAll())
            {
                if (customerid.UserId == id)
                {
                    _customerdal.Delete(customerid);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(), Messages.listed);
        }
        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerdal.GetCustomerDetails());
        }
        public IDataResult<List<Customer>> GetById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(p => p.UserId == id), Messages.succeed);
        }

        public IResult Update(Customer customer)
        {
            _customerdal.Update(customer);
            return new SuccessResult();
        }
    }
}
