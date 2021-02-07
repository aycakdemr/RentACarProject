using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService :IService<Car>
    {
       
        List<CarDetailDto> GetCarDetails();
    }
}
