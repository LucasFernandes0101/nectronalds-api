using NecTronaldsAPI.Domain.Entities;

namespace NecTronaldsAPI.Application.Dtos
{
    public class ItemCardapioDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public static explicit operator ItemCardapioDto(Lanche lanche)
        {
            if (lanche == null)
                return null;

            return new ItemCardapioDto
            {
                Nome = lanche.Nome,
                Descricao = lanche.Descricao,
                Preco = lanche.PrecoVenda
            };
        }
    }
}
