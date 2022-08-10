using Microsoft.EntityFrameworkCore;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Infra.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<TaskDetail> TaskDetails { get; set; }
        public DbSet<Alarm> Alarms { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskListConfiguration());
            modelBuilder.ApplyConfiguration(new TaskDetailConfiguration());
            modelBuilder.ApplyConfiguration(new AlarmConfiguration());
        }
    }
}
