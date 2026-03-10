using System.ComponentModel.DataAnnotations;

namespace FIIsAnalyzer.Models
{
    public class FII
    {
        public int Id { get; set; }

        [Required]
        public string Codigo { get; set; }

        public string Setor { get; set; }
        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public decimal CotacaoAtual { get; set; }

    }
}
