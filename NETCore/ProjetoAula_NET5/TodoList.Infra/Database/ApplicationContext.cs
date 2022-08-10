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
            modelBuilder.Entity<TaskList>(x =>
            {
                x.ToTable("tasklists");
                x.HasKey(x => x.Id); //mapear a chave primária
                x.Property(x => x.ListName).HasColumnType("VARCHAR(100)").IsRequired();
            });
        }
    }
}