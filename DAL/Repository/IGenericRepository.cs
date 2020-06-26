using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Repository.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetEntity(Expression<Func<TEntity, bool>> expression);

        void Create(TEntity item);

        void Update(TEntity item);

        void Delete(uint Id);
    }
}
