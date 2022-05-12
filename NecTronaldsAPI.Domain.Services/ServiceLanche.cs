using NecTronaldsAPI.Domain.Core.Interfaces.Repositories;
using NecTronaldsAPI.Domain.Core.Interfaces.Services;
using NecTronaldsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecTronaldsAPI.Domain.Services
{
    public class ServiceLanche : ServiceBase<Lanche>, IServiceLanche
    {
        private readonly IRepositoryLanche _repositoryLanche;

        public ServiceLanche(IRepositoryLanche repositoryLanche)
            : base(repositoryLanche)
        {
            _repositoryLanche = repositoryLanche;
        }
    }
}
