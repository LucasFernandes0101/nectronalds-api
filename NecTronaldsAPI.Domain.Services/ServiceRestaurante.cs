using NecTronaldsAPI.Domain.Core.Interfaces.Repositories;
using NecTronaldsAPI.Domain.Core.Interfaces.Services;
using NecTronaldsAPI.Domain.Entities;

namespace NecTronaldsAPI.Domain.Services
{
    public class ServiceRestaurante : ServiceBase<Restaurante>, IServiceRestaurante
    {
        private readonly IRepositoryRestaurante _repositoryRestaurante;

        public ServiceRestaurante(IRepositoryRestaurante repositoryRestaurante)
            : base(repositoryRestaurante)
        {
            _repositoryRestaurante = repositoryRestaurante;
        }
    }
}
