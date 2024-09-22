using Microsoft.AspNetCore.Mvc.Rendering;

namespace JojoFinancasApp.ViewModels
{
    public class CompraViewModel
    {

        public double Valor { get; set; }

        public string Descricao { get; set; }

        // Para o pagamento, vamos usar strings para facilitar a seleção na view
        public string TipoPagamentoSelecionado { get; set; }

        public int? NumeroParcelas { get; set; }

        // Para a classe da compra, também usaremos uma string
        public string ClasseCompraSelecionada { get; set; }

        // Propriedades para popula a lista de tipos de pagamento e classes de compra na view
        public IEnumerable<SelectListItem> TiposPagamento { get; set; }
        public IEnumerable<SelectListItem> ClassesCompras { get; set; }
    }
}
