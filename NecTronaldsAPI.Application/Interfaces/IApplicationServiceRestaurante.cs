using NecTronaldsAPI.Application.Dtos;
using System.Collections.Generic;

namespace NecTronaldsAPI.Application.Interfaces
{
    public interface IApplicationServiceRestaurante
    {
        void Add(RestauranteDto restauranteDto);
        void Update(RestauranteDto restauranteDto);
        void Delete(RestauranteDto restauranteDto);
        IEnumerable<RestauranteDto> GetAll();
        List<CardapioDto> GetAllCardapiosRestaurantesAtivos();
        CardapioDto GetCardapioByIdRestaurante(int id);
        RestauranteDto GetById(int id);
    }
}
