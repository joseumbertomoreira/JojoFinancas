using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JojoFinancasApp.Models
{
    public class ClasseCompra
    {

        public ClasseCompra() 
        {
            this.Nome = "descricao padrao";
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Nome")]
        public string Nome { get; set; }
    }
}
