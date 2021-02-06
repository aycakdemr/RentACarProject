using System;
using Entities.Concrete;

using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService:IService<Brand>
    {
        List<Brand> GetBrandsById(int id);
        List<Brand> GetBrandsByName(string name);
    }
}
