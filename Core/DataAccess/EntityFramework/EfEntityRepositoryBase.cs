using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity ,TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (TContext c = new TContext())
            {
                var addedEntity = c.Entry(entity);
                addedEntity.State = EntityState.Added;
                c.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext c = new TContext())
            {
                var deletedEntity = c.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext c = new TContext())
            {
                return c.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext c = new TContext())
            {
                return filter == null
                    ? c.Set<TEntity>().ToList()
                    : c.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity color)
        {
            using (TContext c = new TContext())
            {
                var updatedEntity = c.Entry(color);
                updatedEntity.State = EntityState.Modified;
                c.SaveChanges();
            }
        }
    }
}
