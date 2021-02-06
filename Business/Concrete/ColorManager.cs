using Business.Abstract;
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
        public void Add(Color t)
        {
            _colorDal.Add(t);
            Console.WriteLine("eklendi..");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetColorsById(int id)
        {
            return _colorDal.GetAll(p => p.ColorId == id);
        }

        public List<Color> GetColorsByName(string name)
        {
            return _colorDal.GetAll(p => p.ColorName == name);
        }
    }
}
