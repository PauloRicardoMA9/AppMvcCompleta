using ma9.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ma9.Data.Mappings
{
    class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(fornecedor => fornecedor.Id);

            builder.Property(fornecedor => fornecedor.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(fornecedor => fornecedor.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(fornecedor => fornecedor.Endereco)
                .WithOne(endereco => endereco.Fornecedor);

            // 1 : n => Fornecedor : Produtos
            builder.HasMany(fornecedor => fornecedor.Produtos)
                .WithOne(produto => produto.Fornecedor)
                .HasForeignKey(produto => produto.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }
}
