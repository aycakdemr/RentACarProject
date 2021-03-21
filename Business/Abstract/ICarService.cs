using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService :IService<Car>
    {
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarsFiltered(int brandId, int colorId);
    }
}
