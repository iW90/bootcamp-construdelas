using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Infra.Database
{
    public class TaskListConfiguration : IEntityTypeConfiguration<TaskList>
    {
        public void Configure(EntityTypeBuilder<TaskList> builder)
        {
            builder.ToTable("tasklists");
            builder.HasKey(pk => pk.Id);
            builder.Property(m => m.ListName).HasColumnType("VARCHAR(100)").IsRequired();
        }
    }
}
