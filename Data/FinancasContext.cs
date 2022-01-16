using Microsoft.EntityFrameworkCore;

namespace DesafioPubFuture.Data
{
    public class FinancasContext : DbContext
    {
        public DbSet<Models.Conta>? Contas { get; set; }
        public DbSet<Models.Despesa>? Despesas { get; set; }
        public DbSet<Models.Receita>? Receitas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=sa123456;Persist Security Info=True;User ID=sa;Initial Catalog=Financas;Data Source=NOTE\SQLEXPRESS");
        }
    }
}
