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
        
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetBrandsById(int id)
        {
            return _brandDal.GetAll(p => p.BrandId == id);
        }

        public List<Brand> GetBrandsByName(string name)
        {
            return _brandDal.GetAll(p => p.BrandName == name);
        }
    }

}
