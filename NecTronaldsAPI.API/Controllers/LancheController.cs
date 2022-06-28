using Microsoft.AspNetCore.Mvc;
using NecTronaldsAPI.API.Helpers;
using NecTronaldsAPI.Application;
using NecTronaldsAPI.Application.Dtos;
using NecTronaldsAPI.Application.Interfaces;
using System;

namespace NecTronaldsAPI.API.Controllers
{
    [Route("v1/Lanche/")]
    [ApiController]
    public class LancheController : Controller
    {
        private readonly IApplicationServiceLanche _applicationServiceLanche;

        public LancheController(IApplicationServiceLanche applicationServiceLanche)
        {
            _applicationServiceLanche = applicationServiceLanche;
        }

        [HttpPost]
        public IActionResult Post([FromBody] LancheDto lancheDto)
        {
            var response = new HttpResponse() { Success = true };
            try
            {
                _applicationServiceLanche.Add(lancheDto);
                response.Message = "Lanche adicionado com sucesso!";
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
                response.Content = _applicationServiceLanche.GetAll();
                response.Message = "Lista de Lanches retornada com sucesso!";
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
                response.Content = _applicationServiceLanche.GetById(id);
                response.Message = "Lanche retornado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put([FromBody] LancheDto lancheDto)
        {
            var response = new HttpResponse() { Success = false };
            try
            {
                _applicationServiceLanche.Update(lancheDto);
                response.Message = "Lanche atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] LancheDto lancheDto)
        {
            var response = new HttpResponse() { Success = false };
            try
            {
                _applicationServiceLanche.Delete(lancheDto);
                response.Message = "Lanche removido com sucesso!";
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
