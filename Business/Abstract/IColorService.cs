using System;
using Entities.Concrete;

using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IColorService :IService<Color>
    {
        IDataResult<List<Color>> GetColorsByName(string name);
        
    }
}
