using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using(ReCapDbContext c = new ReCapDbContext())
            {
                var addedEntity = c.Entry(car);
                addedEntity.State = EntityState.Added;
                c.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var deletedEntity = c.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                return c.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                return filter == null
                    ? c.Set<Car>().ToList()
                    : c.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car car)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var updatedEntity = c.Entry(car);
                updatedEntity.State = EntityState.Modified;
                c.SaveChanges();
            }
        }
    }
}
