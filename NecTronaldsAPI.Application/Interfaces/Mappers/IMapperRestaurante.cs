using NecTronaldsAPI.Application.Dtos;
using NecTronaldsAPI.Domain.Entities;
using System.Collections.Generic;

namespace NecTronaldsAPI.Application.Interfaces.Mappers
{
    public interface IMapperRestaurante
    {
        Restaurante MapperDtoToEntity(RestauranteDto restauranteDto);
        IEnumerable<RestauranteDto> MapperListRestaurantesDto(IEnumerable<Restaurante> restaurantes);
        RestauranteDto MapperEntityToDto(Restaurante restaurante);
    }
}
