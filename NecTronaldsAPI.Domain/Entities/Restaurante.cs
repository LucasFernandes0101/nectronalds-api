using NecTronaldsAPI.Domain.Entities.Enums;

namespace NecTronaldsAPI.Domain.Entities
{
    public class Restaurante : Base
    {
        public string Nome { get; set; }
        public Regiao Regiao { get; set; }
        public bool IsAtivo { get; set; }
    }
}
