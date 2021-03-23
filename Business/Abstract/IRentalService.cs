using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService:IService<Rental>
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        Boolean IsRentable(Rental rental);
    }
}
