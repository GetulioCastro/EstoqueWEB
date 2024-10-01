using EstoqueWEB.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueWEB.Infraestrutura.Dados.Mapeamento
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasPrecision(10, 2);

            builder.Property(x => x.Quantidade)
                .HasMaxLength(10)
                .IsRequired();

        }
    }
}
