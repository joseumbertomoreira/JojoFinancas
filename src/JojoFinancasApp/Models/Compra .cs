using System.ComponentModel.DataAnnotations;

namespace JojoFinancasApp.Models
{
    public class Compra
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }

        public int PagamentoId { get; set; }
        public Pagamento Pagamento { get; set; }

        public int ClasseCompraId { get; set; }
        public ClasseCompra ClasseCompra { get; set; }

        public DateTime DataPagamento { get; set; }



    }
}
