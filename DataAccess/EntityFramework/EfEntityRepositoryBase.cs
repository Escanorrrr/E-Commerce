using System.Linq.Expressions;
using Core;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using (ShoppingContext context = new ShoppingContext())
        {
            var addedEntity =context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(TEntity entity)
    {
        using (ShoppingContext context = new ShoppingContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
    {
        using (ShoppingContext context = new ShoppingContext())
        {
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using (ShoppingContext context = new ShoppingContext())
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }

    public void Update(TEntity entity)
    {
        using (ShoppingContext context = new ShoppingContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
            
    }
}