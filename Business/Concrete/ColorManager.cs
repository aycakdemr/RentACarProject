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
//burdan bahsetmiyor musunuz
namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color t)
        {
            _colorDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var colorid in _colorDal.GetAll())
            {
                if (colorid.ColorId == id)
                {
                    _colorDal.Delete(colorid);
                    return new SuccessResult(Messages.deleted);

                }
                
            }
            return new SuccessResult(Messages.error);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(),Messages.succeed);
        }

       
        public IDataResult<List<Color>> GetColorsByName(string name)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorName == name), Messages.succeed);
        }
        public IDataResult<List<Color>> GetById(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorId == id), Messages.succeed);
        }
        public IResult Update(int id,Color t)
        {
            foreach (var _color in _colorDal.GetAll())
            {
                if (_color.ColorId == id)
                {
                    _color.ColorId = t.ColorId;
                    _color.ColorName = t.ColorName;

                    return new SuccessResult(Messages.updated);

                }
            }
            return new SuccessResult(Messages.error);
        }

        
    }
}
