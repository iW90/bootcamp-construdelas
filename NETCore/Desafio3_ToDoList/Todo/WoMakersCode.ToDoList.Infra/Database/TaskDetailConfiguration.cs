using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Infra.Database
{
    public class TaskDetailConfiguration : IEntityTypeConfiguration<TaskDetail>
    {
        public void Configure(EntityTypeBuilder<TaskDetail> builder)
        {
            builder.ToTable("taskdetails");
            builder.HasKey(pk => pk.Id);
            builder.Property(m => m.Descricao).HasColumnType("VARCHAR(300)").IsRequired();
            builder.Property(m => m.DataHora).HasColumnType("DATETIME").IsRequired();
            builder.Property(m => m.Executado).HasColumnType("INT").IsRequired();
            builder.HasOne<TaskList>(m => m.TaskList)
                .WithMany(m => m.Details)
                .HasForeignKey(fk => fk.IdTaskList).IsRequired();
        }
    }
}
