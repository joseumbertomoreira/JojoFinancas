using JojoFinancasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JojoFinancasApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ClasseCompra> ClassesCompra { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<TipoPagamento> TiposPagamentos { get; set; }

    }
}