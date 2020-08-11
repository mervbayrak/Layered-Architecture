using LayeredArchitectureExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureExample.Core.DataAccess.EntityFramework
{
    public class EFEntityResponsitoryBase<TContext, TEntity> : IEntityResponsitory<TEntity>
        where TContext : DbContext, new()
        where TEntity  : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public virtual TEntity Get(Expression<Func<TEntity,bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public virtual TEntity GetInclude<TInclude>(Expression<Func<TEntity,TInclude>> includeEx = null, Expression<Func<TEntity,bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).Include(includeEx).FirstOrDefault();
            }
        }
        public virtual List<TEntity> GetList(Expression<Func<TEntity,bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                                      : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public virtual List<TEntity> GetListInclude<TInclude>(Expression<Func<TEntity,TInclude>> includeEx = null, Expression<Func<TEntity,bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().Include(includeEx).ToList()
                                      : context.Set<TEntity>().Where(filter).Include(includeEx).ToList();
            }
        }
    }
}
