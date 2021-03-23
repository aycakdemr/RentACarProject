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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand t)
        {
            _brandDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var brandid in _brandDal.GetAll())
            {
                if (brandid.Id == id)
                {
                    _brandDal.Delete(brandid);
                    return new SuccessResult(Messages.deleted);

                }

            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll(),Messages.listed);
        }

        public IDataResult<List<Brand>> GetBrandsById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IDataResult<List<Brand>> GetBrandsByName(string name)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.BrandName == name), Messages.succeed);
        }

        public IDataResult<List<Brand>> GetById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.Id == id), Messages.succeed);
        }


        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult();
        }
    }

}
