using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental, ReCapDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from rt in context.Rentals
                             join cr in context.Cars on rt.CarId equals cr.Id
                             join cst in context.Customers on rt.CustomerId equals cst.CustomerId
                             join usr in context.Users on cst.UserId equals usr.Id
                             join brd in context.Brands on cr.BrandId equals brd.Id
                             join clr in context.Colors on cr.ColorId equals clr.Id
                             select new RentalDetailDto
                             {
                                 RentalId=rt.Id,
                                 CompanyName = cst.CompanyName,
                                 CarModelYear = cr.ModelYear,
                                 CarDailyPrice = cr.DailyPrice,
                                 CarDescription = cr.Description,
                                 CarId = rt.CarId,
                                 FirstName = usr.FirstName,
                                 LastName = usr.LastName,
                                 BrandName = brd.BrandName,
                                 ColorName = clr.ColorName,
                                 RentDate = rt.RentStartDate,
                                 ReturnDate = rt.RentEndDate
                             };
                return result.ToList();
            }
        }
    }
}
