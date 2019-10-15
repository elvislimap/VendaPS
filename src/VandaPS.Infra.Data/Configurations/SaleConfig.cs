using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendaPS.Domain.Entities;

namespace VandaPS.Infra.Data.Configurations
{
    public class SaleConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.SaleId);
            builder.Property(s => s.SaleId).ValueGeneratedOnAdd().HasColumnType("int");

            builder.Property(s => s.ClientId).HasColumnType("int").IsRequired();
            builder.Property(s => s.Value).HasColumnType("decimal(10,2)").IsRequired();

            builder.HasOne(s => s.Client).WithMany(c => c.Sales);
        }
    }
}