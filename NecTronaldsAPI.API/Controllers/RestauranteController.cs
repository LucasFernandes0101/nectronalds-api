using Microsoft.AspNetCore.Mvc;
using NecTronaldsAPI.API.Helpers;
using NecTronaldsAPI.Application.Dtos;
using NecTronaldsAPI.Application.Interfaces;
using System;

namespace NecTronaldsAPI.API.Controllers
{
    [Route("v1/Restaurante/")]
    [ApiController]
    public class RestauranteController : Controller
    {
        private readonly IApplicationServiceRestaurante _applicationServiceRestaurante;

        public RestauranteController(IApplicationServiceRestaurante applicationServiceRestaurante)
        {
            _applicationServiceRestaurante = applicationServiceRestaurante;
        }

        [HttpGet]
        [Route("GetAllCardapiosRestaurantesAtivos")]
        public IActionResult GetAllCardapiosRestaurantesAtivos()
        {
            var response = new HttpResponse() { Success = true };
            try
            {
                response.Content = _applicationServiceRestaurante.GetAllCardapiosRestaurantesAtivos();
                response.Message = "Cardápios montados com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetCardapioByIdRestaurante/{id}")]
        public IActionResult GetCardapioByIdRestaurante(int id)
        {
            var response = new HttpResponse() { Success = true };
            try
            {
                response.Content = _applicationServiceRestaurante.GetCardapioByIdRestaurante(id);
                response.Message = "Cardápio montado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] RestauranteDto restauranteDto)
        {
            var response = new HttpResponse() { Success = true };
            try
            {
                _applicationServiceRestaurante.Add(restauranteDto);
                response.Message = "Restaurante adicionado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = new HttpResponse() { Success = true };
            try
            {
                response.Content = _applicationServiceRestaurante.GetAll();
                response.Message = "Lista de restaurantes retornada com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = new HttpResponse() { Success = true };
            try
            {
                response.Content = _applicationServiceRestaurante.GetById(id);
                response.Message = "Restaurante retornado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put([FromBody] RestauranteDto restauranteDto)
        {
            var response = new HttpResponse() { Success = false };
            try
            {
                _applicationServiceRestaurante.Update(restauranteDto);
                response.Message = "Restaurante atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] RestauranteDto restauranteDto)
        {
            var response = new HttpResponse() { Success = false };
            try
            {
                _applicationServiceRestaurante.Delete(restauranteDto);
                response.Message = "Restaurante removido com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }
    }
}
