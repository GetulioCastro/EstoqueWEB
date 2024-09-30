using Microsoft.EntityFrameworkCore;

namespace EstoqueWEB.Infraestrutura.Dados
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(DbContextOptions<EstoqueContext> dbContextOptions) : base(dbContextOptions) 
        {
        }
    }
}
