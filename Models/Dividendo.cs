using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIIsAnalyzer.Models
{
    public class Dividendo
    {
        public int Id { get; set; }

        [Required]
        public int FIIId { get; set; }

        [ForeignKey("FIIId")]
        public FII FII { get; set; }

        [Required]
        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

    }
}
