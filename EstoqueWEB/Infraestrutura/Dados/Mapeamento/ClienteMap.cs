using EstoqueWEB.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueWEB.Infraestrutura.Dados.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.RazaoSocial)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(x => x.CNPJ)
                .HasMaxLength(14)
                .IsRequired();

            builder.HasOne(x => x.Endereco)
                .WithOne(x => x.Cliente);
        }
    }
}
