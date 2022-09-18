using BerthaLutzStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaLutzStore.Infra.Database
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(pk => pk.IdUser); //Coluna Id do Usuário

            builder.Property(p => p.UserName) //Coluna Nome do Usuário
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            builder.Property(p => p.Email) //Coluna Email
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            builder.Property(p => p.Phone) //Coluna Número de Celular
                .HasColumnType("VARCHAR(14)");
            builder.Property(p => p.Address) //Coluna Endereço
                .HasColumnType("VARCHAR(150)")
                .IsRequired();
            builder.Property(p => p.RegisteredAt) //Coluna Data de Registro do Usuário
                .HasColumnType("DATETIME");
        }
    }
}
