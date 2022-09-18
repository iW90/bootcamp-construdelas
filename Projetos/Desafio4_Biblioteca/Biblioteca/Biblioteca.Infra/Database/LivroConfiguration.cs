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
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livros");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Titulo)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            builder.Property(p => p.QuantidadeDisponivel)
                .HasColumnType("INT")
                .IsRequired();
            builder.HasOne(fk => fk.Autor)
                .WithMany(fk => fk.Livros)
                .HasForeignKey(fk => fk.IdAutor);
        }
    }
}
