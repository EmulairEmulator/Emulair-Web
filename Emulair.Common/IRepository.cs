using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.Common
{
    public interface IRepository<TEntity>
            where TEntity : class, IEntity
    {
        IQueryable<TEntity> Get();
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entitty);
        TEntity Find(Guid id);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
    }
}
