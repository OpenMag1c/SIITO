using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class OsnastkaTypeConfig : IEntityTypeConfiguration<OsnastkaType>
{
    public void Configure(EntityTypeBuilder<OsnastkaType> entity)
    {
        entity.ToTable("OsnastkaType");

        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("OsnastkaTypeId");

        entity.Property(e => e.Name)
            .HasColumnName("Name")
            .IsRequired();
    }
}
