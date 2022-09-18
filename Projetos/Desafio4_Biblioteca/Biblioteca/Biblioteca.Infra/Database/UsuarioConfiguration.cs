using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Core.Entities;

namespace Biblioteca.Infra.Database
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            builder.Property(p => p.Endereco)
                .HasColumnType("VARCHAR(250)")
                .IsRequired();
            builder.Property(p => p.Telefone)
                .HasColumnType("VARCHAR(15)");
        }
    }
}
