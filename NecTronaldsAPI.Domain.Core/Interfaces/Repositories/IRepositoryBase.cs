using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NecTronaldsAPI.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filtro = null);
        TEntity GetById(int id);
    }
}
