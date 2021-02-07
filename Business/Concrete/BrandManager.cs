using Business.Abstract;
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
        public void Add(Brand t)
        {
            _brandDal.Add(t);
            Console.WriteLine("eklendi");
        }

        public void Delete(int id)
        {
            foreach (var brandid in _brandDal.GetAll())
            {
                if (brandid.BrandId == id)
                {
                    _brandDal.Delete(brandid);
                    Console.WriteLine("silindi");

                }
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetById(int id)
        {
            return _brandDal.GetAll(p => p.BrandId == id);
        }

        
        public void Update(int id,Brand t)
        {
            foreach (var _brand in _brandDal.GetAll())
            {
                if (_brand.BrandId == id)
                {
                    _brand.BrandId = t.BrandId;
                    _brand.BrandName = t.BrandName;
                    
                    Console.WriteLine("güncellendi");

                }
            }
        }
    }

}
