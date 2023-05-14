using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class InstrumentConfig : IEntityTypeConfiguration<Instrument>
{
    public void Configure(EntityTypeBuilder<Instrument> entity)
    {
        entity.ToTable("Instrument");

        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("InstrumentId");

        entity.Property(e => e.Name)
            .HasColumnName("Name")
            .IsRequired();

        entity.Property(e => e.Code)
            .HasColumnName("Code")
            .IsRequired();

        entity.Property(e => e.Dimensions)
            .HasColumnName("Dimensions")
            .IsRequired();

        entity.Property(e => e.Picture)
            .HasColumnName("Picture")
            .IsRequired(false);

        entity.Property(e => e.Measure)
            .HasColumnName("Measure")
            .IsRequired();

        entity.Property(e => e.Price)
            .HasColumnName("Price")
            .IsRequired();

        entity.Property(e => e.CreatedAt)
            .HasColumnName("CreatedAt")
            .IsRequired(false);

        entity.Property(e => e.UpdatedAt)
            .HasColumnName("UpdatedAt")
            .IsRequired(false);

        entity.HasOne(x => x.InstrumentType)
            .WithMany(x => x.Instruments)
            .HasForeignKey(x => x.InstrumentTypeId);

        entity.HasOne(x => x.Gost)
            .WithMany(x => x.Instruments)
            .HasForeignKey(x => x.GostId)
            .IsRequired(false);
    }
}
