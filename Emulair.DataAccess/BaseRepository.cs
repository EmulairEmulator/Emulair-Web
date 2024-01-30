using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Emulair.Common;
using Emulair.DataAccess.Context;

namespace Emulair.DataAccess
{
    public class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly EmulairWEBContext Context;

        public BaseRepository(EmulairWEBContext context)
        {
            this.Context = context;
        }

        public IQueryable<TEntity> Get()
        {
            return Context.Set<TEntity>().AsQueryable();
        }
        public TEntity Insert(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            return entity;
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
            return entity;
        }

        public TEntity Find(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public DbSet<TEntity> Set(TEntity entity)
        {
            return Context.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
    }
}
