using System.ComponentModel.DataAnnotations;
namespace AulaApp1.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Informe o nome do produto")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 letras")]
        public string? Nome { get; set; } = "";
        [Range(0.01, double.MaxValue, ErrorMessage = "Informe o valor do produto maior que zero")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Informe a quantidade do produto")]
        public int Quantidade { get; set; } = 0;
    }
}
