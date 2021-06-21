using ma9.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ma9.Data.Mappings
{
    class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(produto => produto.Id);

            builder.Property(produto => produto.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(produto => produto.Descricao)
                .HasColumnType("varchar(1000)");

            builder.Property(produto => produto.Imagem)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Produtos");
        }
    }
}
