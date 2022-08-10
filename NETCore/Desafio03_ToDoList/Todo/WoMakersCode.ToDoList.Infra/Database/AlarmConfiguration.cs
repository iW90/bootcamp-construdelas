using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Infra.Database
{
    public class AlarmConfiguration : IEntityTypeConfiguration<Alarm>
    {
        public void Configure(EntityTypeBuilder<Alarm> builder)
        {
            builder.ToTable("alarms");
            builder.HasKey(pk => pk.Id);
            builder.Property(m => m.DataHora).HasColumnType("DATETIME").IsRequired();
            builder.HasOne<TaskDetail>(m => m.TaskDetail)
                    .WithMany(m => m.Alarms)
                    .HasForeignKey(fk => fk.IdTaskDetail).IsRequired();
        }
    }
}
