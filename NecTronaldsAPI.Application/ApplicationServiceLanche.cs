using NecTronaldsAPI.Application.Dtos;
using NecTronaldsAPI.Application.Interfaces;
using NecTronaldsAPI.Application.Interfaces.Mappers;
using NecTronaldsAPI.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecTronaldsAPI.Application
{
    public class ApplicationServiceLanche : IApplicationServiceLanche
    {
        private readonly IMapperLanche _mapperLanche;
        private readonly IServiceLanche _serviceLanche;

        public ApplicationServiceLanche(IMapperLanche mapperLanche, IServiceLanche serviceLanche)
        {
            _mapperLanche = mapperLanche;
            _serviceLanche = serviceLanche;
        }

        public void Add(LancheDto lancheDto)
        {
            var lanche = _mapperLanche.MapperDtoToEntity(lancheDto);
            _serviceLanche.Add(lanche);
        }

        public void Delete(LancheDto lancheDto)
        {
            var lanche = _mapperLanche.MapperDtoToEntity(lancheDto);
            _serviceLanche.Delete(lanche);
        }

        public IEnumerable<LancheDto> GetAll()
        {
            var lanches = _serviceLanche.GetAll();
            return _mapperLanche.MapperListLanchesDto(lanches);
        }

        public LancheDto GetById(int id)
        {
            var lanche = _serviceLanche.GetById(id);
            return _mapperLanche.MapperEntityToDto(lanche);
        }

        public void Update(LancheDto lancheDto)
        {
            var lanche = _mapperLanche.MapperDtoToEntity(lancheDto);
            _serviceLanche.Update(lanche);
        }


    }
}
