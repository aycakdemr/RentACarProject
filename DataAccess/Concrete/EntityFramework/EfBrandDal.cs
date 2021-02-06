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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand brand)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var addedEntity = c.Entry(brand);
                addedEntity.State = EntityState.Added;
                c.SaveChanges();
            }
        }

        public void Delete(Brand brand)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var deletedEntity = c.Entry(brand);
                deletedEntity.State = EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                return c.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                return filter == null
                    ? c.Set<Brand>().ToList()
                    : c.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand brand)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var updatedEntity = c.Entry(brand);
                updatedEntity.State = EntityState.Modified;
                c.SaveChanges();
            }
        }
    }
}
