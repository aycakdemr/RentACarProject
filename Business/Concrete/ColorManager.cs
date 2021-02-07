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

        public void Delete(int id)
        {
            foreach (var colorid in _colorDal.GetAll())
            {
                if (colorid.ColorId == id)
                {
                    _colorDal.Delete(colorid);
                    Console.WriteLine("silindi");

                }
            }
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

       
        public List<Color> GetColorsByName(string name)
        {
            return _colorDal.GetAll(p => p.ColorName == name);
        }
        public List<Color> GetById(int id)
        {
            return _colorDal.GetAll(p => p.ColorId == id);
        }
        public void Update(int id,Color t)
        {
            foreach (var _color in _colorDal.GetAll())
            {
                if (_color.ColorId == id)
                {
                    _color.ColorId = t.ColorId;
                    _color.ColorName = t.ColorName;

                    Console.WriteLine("güncellendi");

                }
            }
        }

    }
}
