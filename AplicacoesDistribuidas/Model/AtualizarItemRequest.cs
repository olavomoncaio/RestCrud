namespace AplicacoesDistribuidas.Model
{
    public class AtualizarItemRequest
    {
        public int CardapioId { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public bool Disponivel { get; set; }
        public string Ingredientes { get; set; }
    }
}
