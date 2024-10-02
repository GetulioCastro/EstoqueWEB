using EstoqueWEB.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueWEB.Infraestrutura.Dados.Mapeamento
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Rua)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(x => x.Complemento)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.Cidade)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.Estado)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.CEP)
                .HasMaxLength(8)
                .IsRequired();

            builder.HasOne(x => x.Cliente)
                .WithOne(x => x.Endereco);

            builder.HasOne(x => x.Fornecedor)
                .WithOne(x => x.Endereco);
        }
    }
}
