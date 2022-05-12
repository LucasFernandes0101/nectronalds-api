using NecTronaldsAPI.Domain.Core.Interfaces.Repositories;
using NecTronaldsAPI.Domain.Entities;

namespace NecTronaldsAPI.Infrastructure.Data.Repositories
{
    public class RepositoryRestaurante : RepositoryBase<Restaurante>, IRepositoryRestaurante
    {
        private readonly SqlContext _sqlContext;

        public RepositoryRestaurante(SqlContext sqlContext)
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
