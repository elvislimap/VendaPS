using Microsoft.EntityFrameworkCore;
using VandaPS.Infra.Data.Configurations;
using VendaPS.Domain.Entities;

namespace VandaPS.Infra.Data.Contexts
{
    public class ContextEf : DbContext
    {
        public ContextEf(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForSqlServerUseIdentityColumns();

            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new SaleConfig());
            modelBuilder.ApplyConfiguration(new SaleItemConfig());
        }
    }
}