using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IDataResult<List<Customer>> GetById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(p => p.UserId == id), Messages.succeed);
        }

        public IResult Update(int id, Customer t)
        {
            foreach (var _customer in _customerdal.GetAll())
            {
                if (_customer.UserId == id)
                {
                    _customer.UserId = t.UserId;
                    _customer.CompanyName = t.CompanyName;

                    return new SuccessResult(Messages.updated);

                }
            }
            return new SuccessResult(Messages.error);
        }
    }
}
