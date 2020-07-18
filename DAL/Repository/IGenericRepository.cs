using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Repository.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetEntity(Expression<Func<TEntity, bool>> expression);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(uint entityId);
     
        void Delete(TEntity entity);
    }
}
