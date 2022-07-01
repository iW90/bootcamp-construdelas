using Microsoft.EntityFrameworkCore;
using TodoList.Core.Entities;

namespace TodoList.Infra.Database
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=todolist;User Id=todolistuser;Password=340$Uuxwp7Mcxo7Khy;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskList>(m =>
            {
                m.ToTable("tasklists");
                m.HasKey(m => m.Id);
                m.Property(m => m.ListName).HasColumnType("VARCHAR(100)").IsRequired();
            });

            modelBuilder.Entity<TaskDetail>(m =>
            {
                m.ToTable("taskdetails");
                m.HasKey(m => m.Id);
                m.Property(m => m.Descricao).HasColumnType("VARCHAR(300)").IsRequired();
                m.Property(m => m.DataHora).HasColumnType("DATETIME").IsRequired();
                m.Property(m => m.Executado).HasColumnType("INT").IsRequired();
                m.HasOne<TaskList>(m => m.TaskList)
                    .WithMany(m => m.Details)
                    .HasForeignKey(f => f.IdTaskList).IsRequired();
            });
        }
    }
}