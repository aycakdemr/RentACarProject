
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from cr in filter==null? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on cr.BrandId equals b.Id
                             join cl in context.Colors
                             on cr.ColorId equals cl.Id

                             select new CarDetailDto
                             {

                                 CarId = cr.Id,
                                 ColorId=cl.Id,
                                 BrandId=b.Id,
                                 CarModelYear = cr.ModelYear,
                                 CarDescription = cr.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 CarDailyPrice = cr.DailyPrice
                             };
                return result.ToList();
            }
        }

    }
}
