using NecTronaldsAPI.Application.Dtos;
using NecTronaldsAPI.Application.Interfaces.Mappers;
using NecTronaldsAPI.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NecTronaldsAPI.Infrastructure.Mappers
{
    public class MapperRestaurante : IMapperRestaurante
    {
        public Restaurante MapperDtoToEntity(RestauranteDto restauranteDto)
        {
            if (restauranteDto != null)
            {
                return new Restaurante
                {
                    Id = restauranteDto.Id != null ? restauranteDto.Id.Value : 0,
                    Nome = restauranteDto.Nome,
                    IsAtivo = restauranteDto.IsAtivo,
                    Regiao = restauranteDto.Regiao
                };
            }

            return null;
        }

        public RestauranteDto MapperEntityToDto(Restaurante restaurante)
        {
            if (restaurante != null)
            {
                return new RestauranteDto
                {
                    Id = restaurante.Id,
                    Nome = restaurante.Nome,
                    Regiao = restaurante.Regiao,
                    IsAtivo = restaurante.IsAtivo
                };
            }

            return null;
        }

        public IEnumerable<RestauranteDto> MapperListRestaurantesDto(IEnumerable<Restaurante> restaurantes)
        {
            if (restaurantes != null)
            {
                return restaurantes.Select(x =>
                    new RestauranteDto
                    {
                        Id = x.Id,
                        IsAtivo = x.IsAtivo,
                        Nome = x.Nome,
                        Regiao = x.Regiao
                    }
                );
            }

            return null;
        }
    }
}
