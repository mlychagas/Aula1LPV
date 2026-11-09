using System.ComponentModel.DataAnnotations;
namespace AulaApp1.Components.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 letras")]
        public string Nome { get; set; } = "";
    
        [Range(0, 100000, ErrorMessage = "Permitido de 0 a 100.000")]
        public int Quantidade { get; set; }
    }
}

