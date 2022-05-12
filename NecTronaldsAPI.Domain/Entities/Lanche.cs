namespace NecTronaldsAPI.Domain.Entities
{
    public class Lanche : Base
    {
        public int IdRestaurante { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoVenda { get; set; }
        public bool IsDisponivelCardapio { get; set; }
    }
}
