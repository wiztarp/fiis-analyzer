namespace FIIsAnalyzer.Models
{
    public class HistoricoCotacao
    {
        public int Id { get; set; }

        // Chave estrangeira para o FII
        public int FiiId { get; set; }
        public FII Fii { get; set; }

        public decimal Cotacao { get; set; }

        // Quantidade na época (pode mudar ao longo do tempo)
        public int Quantidade { get; set; }

        public DateTime DataReferencia { get; set; }

    }
}
