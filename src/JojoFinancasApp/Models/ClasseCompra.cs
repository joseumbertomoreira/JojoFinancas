using System.ComponentModel.DataAnnotations;

namespace JojoFinancasApp.Models
{
    public class ClasseCompra
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
    }
}
