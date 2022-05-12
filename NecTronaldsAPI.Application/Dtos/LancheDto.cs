namespace NecTronaldsAPI.Application.Dtos
{
    public class LancheDto
    {
        public int? Id { get; set; }
        public int IdRestaurante { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoVenda { get; set; }
        public bool IsDisponivelCardapio { get; set; }
    }
}
