using ma9.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ma9.Data.Mappings
{
    class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(endereco => endereco.Id);

            builder.Property(endereco => endereco.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(endereco => endereco.Numero)
                .HasColumnType("varchar(50)");

            builder.Property(endereco => endereco.Complemento)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(endereco => endereco.Cep)
                .HasColumnType("varchar(8)");

            builder.Property(endereco => endereco.Bairro)
                .HasColumnType("varchar(100)");

            builder.Property(endereco => endereco.Cidade)
                .HasColumnType("varchar(100)");

            builder.Property(endereco => endereco.Estado)
                .HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}
