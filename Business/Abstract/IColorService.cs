using System;
using Entities.Concrete;

using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService :IService<Color>
    {
        List<Color> GetColorsById(int id);
        List<Color> GetColorsByName(string name);
    }
}
