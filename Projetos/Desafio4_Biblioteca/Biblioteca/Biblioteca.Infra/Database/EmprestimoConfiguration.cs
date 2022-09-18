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
    public class EmprestimoConfiguration : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("emprestimos");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.DataEmprestimo)
                .HasColumnType("DATETIME")
                .IsRequired();
            builder.Property(p => p.DataDevolucao)
                .HasColumnType("DATETIME");
            builder.HasOne(fk => fk.Livro)
                .WithMany(fk => fk.Emprestimos)
                .HasForeignKey(fk => fk.IdLivro);
            builder.HasOne(fk => fk.Usuario)
                .WithMany(fk => fk.Emprestimos)
                .HasForeignKey(fk => fk.IdUsuario);
        }
    }
}
