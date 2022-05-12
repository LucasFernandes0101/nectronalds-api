using NecTronaldsAPI.Application.Dtos;
using NecTronaldsAPI.Application.Interfaces.Mappers;
using NecTronaldsAPI.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NecTronaldsAPI.Infrastructure.Mappers
{
    public class MapperLanche : IMapperLanche
    {
        public Lanche MapperDtoToEntity(LancheDto lancheDto)
        {
            if (lancheDto != null)
            {
                return new Lanche
                {
                    Id = lancheDto.Id != null ? lancheDto.Id.Value : 0,
                    Nome = lancheDto.Nome,
                    IdRestaurante = lancheDto.IdRestaurante,
                    Descricao = lancheDto.Descricao,
                    PrecoVenda = lancheDto.PrecoVenda,
                    IsDisponivelCardapio = lancheDto.IsDisponivelCardapio
                };
            }

            return null;
        }

        public LancheDto MapperEntityToDto(Lanche lancheDto)
        {
            if (lancheDto != null)
            {
                return new LancheDto
                {
                    Id = lancheDto.Id,
                    Nome = lancheDto.Nome,
                    IdRestaurante = lancheDto.IdRestaurante,
                    Descricao = lancheDto.Descricao,
                    PrecoVenda = lancheDto.PrecoVenda,
                    IsDisponivelCardapio = lancheDto.IsDisponivelCardapio
                };
            }

            return null;
        }

        public IEnumerable<LancheDto> MapperListLanchesDto(IEnumerable<Lanche> lanches)
        {
            if (lanches != null)
            {
                return lanches.Select(x =>
                    new LancheDto
                    {
                        Id = x.Id,
                        Nome = x.Nome,
                        IdRestaurante = x.IdRestaurante,
                        Descricao = x.Descricao,
                        PrecoVenda = x.PrecoVenda,
                        IsDisponivelCardapio = x.IsDisponivelCardapio
                    }
                );
            }

            return null;
        }
    }
}
