using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendaPS.Domain.Entities;

namespace VandaPS.Infra.Data.Configurations
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);
            builder.Property(c => c.ClientId).ValueGeneratedOnAdd().HasColumnType("int");

            builder.Property(c => c.Cpf).HasColumnType("varchar(11)").HasMaxLength(11).IsRequired();
            builder.Property(c => c.Name).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();
            builder.Property(c => c.BirthDate).HasColumnType("datetime");
        }
    }
}