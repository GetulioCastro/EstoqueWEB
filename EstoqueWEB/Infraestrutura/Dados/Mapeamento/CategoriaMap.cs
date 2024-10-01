using EstoqueWEB.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueWEB.Infraestrutura.Dados.Mapeamento
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasMaxLength(300)
                .IsRequired();

            builder.HasMany(x => x.Produtos)
                .WithOne(x => x.Categoria);
        }
    }
}
