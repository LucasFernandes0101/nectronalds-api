using NecTronaldsAPI.Domain.Core.Interfaces.Repositories;
using NecTronaldsAPI.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NecTronaldsAPI.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(TEntity entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filtro = null)
        {
            return _repositoryBase.GetAll(filtro);
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _repositoryBase.Update(entity);
        }
    }
}
