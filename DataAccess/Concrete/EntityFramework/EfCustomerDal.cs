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
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, ReCapDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from ct in context.Customers
                             join us in context.Users
                                 on ct.UserId equals us.Id
                             select new CustomerDetailDto
                             {
                                 CutomerId = ct.UserId,
                                 UserId = us.Id,
                                 CompanyName = ct.CompanyName,
                                 Email = us.Email,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 Status = us.Status
                             };
                return result.ToList();

            }
        }
    }
}
