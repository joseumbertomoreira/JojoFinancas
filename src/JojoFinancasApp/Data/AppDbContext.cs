using JojoFinancasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JojoFinancasApp.Data
{
    public class AppDbContext : DbContext
    {

        DbSet<ClasseCompra> ClassesCompra { get; set; }
        DbSet<Compra> Compras { get; set; }
        DbSet<Pagamento> Pagamentos { get; set; }
        DbSet<TipoPagamento> TiposPagamentos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}