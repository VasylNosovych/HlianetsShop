using DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;

        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();

        public TEntity GetEntity(Expression<Func<TEntity, bool>> predicate)
        {
            //var db = _dbSet.Where(predicate).
            // створити конструктор, який буде приймати DbSet від відповідної ентіті
        }

        public void Create(TEntity TEntity) => db.TEntitys.Add(TEntity);

        public void Update(TEntity TEntity) => db.Update(TEntity);
        //db.Entry(TEntity).State = EntityState.Modified;

        public void Delete(uint TEntityId)
        {
            TEntity TEntity = GetById(TEntityId);
            if (TEntity != null)
            {
                db.TEntitys.Remove(TEntity);
            }
        }
    }
}
