using BerthaLutzStore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BerthaLutzStore.Infra.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ItemOrder> OrderedItens { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}

/*
- Comando para criar o arquivo Migrations:
dotnet ef --startup-project ./BerthaLutzStore.API/BerthaLutzStore.API.csproj  migrations add Tables -p ./BerthaLutzStore.Infra/BerthaLutzStore.Infra.csproj

- Comando para criar as tabelas no SQL (enquanto o update automático está desabilitado):
dotnet ef database update --project ./BerthaLutzStore.API
 */