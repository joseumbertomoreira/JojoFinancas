using System.ComponentModel.DataAnnotations;

namespace JojoFinancasApp.Models
{
    public class Pagamento
    {


        public Pagamento() 
        {
            TipoPagamento = new TipoPagamento();
        }

        [Key]
        public int Id { get; set; }
        public int TipoPagamentoId { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public int? NumeroParcelas { get; set; }
    }
}
