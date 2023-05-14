using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class InstrumentTypeConfig : IEntityTypeConfiguration<InstrumentType>
{
    public void Configure(EntityTypeBuilder<InstrumentType> entity)
    {
        entity.ToTable("InstrumentType");

        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("InstrumentTypeId");

        entity.Property(e => e.Name)
            .HasColumnName("Name")
            .IsRequired();
    }
}