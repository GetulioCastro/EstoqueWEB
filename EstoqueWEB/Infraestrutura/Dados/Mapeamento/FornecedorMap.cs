using EstoqueWEB.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueWEB.Infraestrutura.Dados.Mapeamento
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.CNPJ)
                .HasMaxLength(14)
                .IsRequired();

            builder.HasOne(x => x.Endereco)
                .WithOne(x => x.Fornecedor);

        }
    }
}
