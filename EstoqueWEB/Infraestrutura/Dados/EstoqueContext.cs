using EstoqueWEB.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;

namespace EstoqueWEB.Infraestrutura.Dados
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public EstoqueContext(DbContextOptions<EstoqueContext> dbContextOptions) : base(dbContextOptions) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // registrar todos os Mappings
            var assembly = typeof(EstoqueContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
