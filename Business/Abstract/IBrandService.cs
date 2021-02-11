using System;
using Entities.Concrete;

using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IBrandService:IService<Brand>
    {
        IDataResult<List<Brand>> GetBrandsByName(string name);
        
    }
}
