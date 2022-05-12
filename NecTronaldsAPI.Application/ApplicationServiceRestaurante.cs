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
    public class ApplicationServiceRestaurante : IApplicationServiceRestaurante
    {
        private readonly IServiceRestaurante _serviceRestaurante;
        private readonly IServiceLanche _serviceLanche;
        private readonly IMapperRestaurante _mapperRestaurante;

        public ApplicationServiceRestaurante(IServiceRestaurante serviceRestaurante,
            IMapperRestaurante mapperRestaurante,
            IServiceLanche serviceLanche)
        {
            _mapperRestaurante = mapperRestaurante;
            _serviceLanche = serviceLanche;
            _serviceRestaurante = serviceRestaurante;
        }

        public List<CardapioDto> GetAllCardapiosRestaurantesAtivos()
        {
            var restaurantesAtivos = _serviceRestaurante.GetAll(x => x.IsAtivo);

            var idsRestaurantesAtivos = restaurantesAtivos.Select(x => x.Id).ToList();

            var lanchesCardapioRestaurantesAtivos = _serviceLanche.GetAll(x =>
                idsRestaurantesAtivos.Contains(x.IdRestaurante) && x.IsDisponivelCardapio);

            var cardapios = new List<CardapioDto>();

            foreach (var restaurante in restaurantesAtivos)
            {
                var lanchesRestaurante = lanchesCardapioRestaurantesAtivos.Where(x => 
                    x.IdRestaurante.Equals(restaurante.Id)).ToList();

                cardapios.Add(new CardapioDto
                {
                    NomeRestaurante = restaurante.Nome,
                    IdRestaurante = restaurante.Id,
                    RegiaoRestaurante = restaurante.Regiao,
                    Itens = lanchesRestaurante.Select(x => (ItemCardapioDto) x).ToList()
                });
            }

            return cardapios;
        }

        public CardapioDto GetCardapioByIdRestaurante(int id)
        {
            var restaurante = _serviceRestaurante.GetById(id);

            if (restaurante == null)
                throw new Exception("Restaurante não encontrado!");

            var lanchesRestaurante = _serviceLanche.GetAll(x => x.IdRestaurante == id && x.IsDisponivelCardapio);

            var cardapio = new CardapioDto()
            {
                IdRestaurante = restaurante.Id,
                NomeRestaurante = restaurante.Nome,
                RegiaoRestaurante = restaurante.Regiao,
                Itens = lanchesRestaurante.Select(x => (ItemCardapioDto)x).ToList()
            };

            return cardapio;
        }

        public void Add(RestauranteDto restauranteDto)
        {
            var restaurante = _mapperRestaurante.MapperDtoToEntity(restauranteDto);
            _serviceRestaurante.Add(restaurante);
        }

        public void Delete(RestauranteDto restauranteDto)
        {
            var restaurante = _mapperRestaurante.MapperDtoToEntity(restauranteDto);
            _serviceRestaurante.Delete(restaurante);
        }

        public IEnumerable<RestauranteDto> GetAll()
        {
            var restaurantes = _serviceRestaurante.GetAll();
            return _mapperRestaurante.MapperListRestaurantesDto(restaurantes);
        }

        public RestauranteDto GetById(int id)
        {
            var restaurante = _serviceRestaurante.GetById(id);
            return _mapperRestaurante.MapperEntityToDto(restaurante);
        }

        public void Update(RestauranteDto restauranteDto)
        {
            var restaurante = _mapperRestaurante.MapperDtoToEntity(restauranteDto);
            _serviceRestaurante.Update(restaurante);
        }
    }
}
