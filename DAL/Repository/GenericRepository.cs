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

        public GenericRepository(HlianetsContext db)
        {
            _dbSet = db.Set<TEntity>();
        }

        public GenericRepository(DbSet<TEntity> entities)
        {
            _dbSet = entities;
        }

        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();

        public TEntity GetEntity(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression).First<TEntity>();
        }

        public void Create(TEntity entity) => _dbSet.Add(entity);

        public void Update(TEntity entity) => _dbSet.Update(entity);

        public void Delete(uint entityId)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
