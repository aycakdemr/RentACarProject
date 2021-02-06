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
    public class EfColorDal : IColorDal
    {
        public void Add(Color color)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var addedEntity = c.Entry(color);
                addedEntity.State = EntityState.Added;
                c.SaveChanges();
            }
        }

        public void Delete(Color color)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var deletedEntity = c.Entry(color);
                deletedEntity.State = EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                return c.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                return filter == null
                    ? c.Set<Color>().ToList()
                    : c.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color color)
        {
            using (ReCapDbContext c = new ReCapDbContext())
            {
                var updatedEntity = c.Entry(color);
                updatedEntity.State = EntityState.Modified;
                c.SaveChanges();
            }
        }
    }
}
