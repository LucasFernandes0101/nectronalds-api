using NecTronaldsAPI.Domain.Entities.Enums;

namespace NecTronaldsAPI.Application.Dtos
{
    public class RestauranteDto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public Regiao Regiao { get; set; }
        public bool IsAtivo { get; set; }
    }
}
