using BerthaLutzStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaLutzStore.Infra.Database
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(pk => pk.IdProduct); //Coluna Id do Produto

            builder.Property(p => p.ProductName) //Coluna Nome do Produto
                .HasColumnType("VARCHAR(48)")
                .IsRequired();
            builder.Property(p => p.Brand) //Coluna Marca do Produto
                .HasColumnType("VARCHAR(48)")
                .IsRequired();
            builder.Property(p => p.Description) //Coluna Descrição
                .HasColumnType("VARCHAR(248)");
            builder.Property(p => p.SalePrice) //Coluna Preço
                .HasColumnType("DECIMAL(10, 2)")
                .IsRequired();
            builder.Property(p => p.Storage) //Coluna Estoque
                .HasColumnType("INT")
                .IsRequired();
            builder.Property(p => p.RegisteredAt) //Coluna Data de Registro do Produto
                .HasColumnType("DATETIME");
        }
    }
}

