using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendaPS.Domain.Entities;

namespace VandaPS.Infra.Data.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductId).ValueGeneratedOnAdd().HasColumnType("int");

            builder.Property(p => p.Ean).HasColumnType("varchar(13)").HasMaxLength(13).IsRequired();
            builder.Property(p => p.Description).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal(10,2)").IsRequired();
        }
    }
}