using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendaPS.Domain.Entities;

namespace VandaPS.Infra.Data.Configurations
{
    public class SaleItemConfig : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.HasKey(s => new { s.SaleId, s.ProductId });

            builder.Property(s => s.SaleId).HasColumnType("int");
            builder.Property(s => s.ProductId).HasColumnType("int");

            builder.HasOne(s => s.Sale).WithMany(s => s.SaleItems);
            builder.HasOne(s => s.Product).WithMany(p => p.SaleItems);
        }
    }
}