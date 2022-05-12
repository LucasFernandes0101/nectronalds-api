using NecTronaldsAPI.Domain.Core.Interfaces.Repositories;
using NecTronaldsAPI.Domain.Entities;

namespace NecTronaldsAPI.Infrastructure.Data.Repositories
{
    public class RepositoryLanche : RepositoryBase<Lanche>, IRepositoryLanche
    {
        private readonly SqlContext _sqlContext;

        public RepositoryLanche(SqlContext sqlContext)
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
