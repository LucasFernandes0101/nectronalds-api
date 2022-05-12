using NecTronaldsAPI.Application.Dtos;
using NecTronaldsAPI.Domain.Entities;
using System.Collections.Generic;

namespace NecTronaldsAPI.Application.Interfaces.Mappers
{
    public interface IMapperLanche
    {
        Lanche MapperDtoToEntity(LancheDto lancheDto);
        IEnumerable<LancheDto> MapperListLanchesDto(IEnumerable<Lanche> lanches);
        LancheDto MapperEntityToDto(Lanche lanche);
    }
}