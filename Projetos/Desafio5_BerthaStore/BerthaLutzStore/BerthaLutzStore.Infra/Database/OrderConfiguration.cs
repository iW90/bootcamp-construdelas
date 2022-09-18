using BerthaLutzStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaLutzStore.Infra.Database
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(pk => pk.IdOrder); //Coluna Id do Pedido

            builder.Property(p => p.PaymentType) //Coluna Tipo de Pagamento
                .HasColumnType("VARCHAR(24)")
                .IsRequired();
            builder.Property(p => p.Total) //Coluna Valor total do Pedido
                .HasColumnType("DECIMAL(10, 2)");
            builder.Property(p => p.ShippingDate) //Coluna Data de Despacho
                .HasColumnType("DATETIME");
            builder.Property(p => p.Status) //Coluna Situação do Pedido
                .HasColumnType("VARCHAR(24)");
            builder.Property(p => p.OrderedAt) //Coluna Data em que o Pedido foi registrado
                .HasColumnType("DATETIME");

            builder.HasOne(fk => fk.User) //FK Usuário
                .WithMany(fk => fk.Orders)
                .HasForeignKey(fk => fk.IdUser);
        }
    }
}
