using NecTronaldsAPI.Domain.Entities.Enums;
using System.Collections.Generic;

namespace NecTronaldsAPI.Application.Dtos
{
    public class CardapioDto
    {
        public int IdRestaurante { get; set; }
        public string NomeRestaurante { get; set; }
        public Regiao RegiaoRestaurante { get; set; }
        public List<ItemCardapioDto> Itens { get; set; }
    }
}
