using BerthaLutzStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaLutzStore.Infra.Database
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.ToTable("OrderedItems");

            builder.HasKey(pk => pk.IdItemOrder); //Coluna Id do Item

            builder.Property(p => p.Quantity) //Coluna Quantidade de Itens
                .HasColumnType("INT");
            builder.Property(p => p.UnitPrice) //Coluna Preço Unitário
                .HasColumnType("DECIMAL(10, 2)");

            builder.HasOne(fk => fk.Product) //FK Produto
                .WithMany(fk => fk.OrderedItems)
                .HasForeignKey(fk => fk.IdProduct)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(fk => fk.Order) //FK Pedido
                .WithMany(fk => fk.OrderedItems)
                .HasForeignKey(fk => fk.IdOrder);
        }
    }
}
