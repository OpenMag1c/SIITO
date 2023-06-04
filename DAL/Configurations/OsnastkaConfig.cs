using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class OsnastkaConfig : IEntityTypeConfiguration<Osnastka>
{
    public void Configure(EntityTypeBuilder<Osnastka> entity)
    {
        entity.ToTable("Osnastka");

        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("OsnastkaId");

        entity.Property(e => e.Name)
            .HasColumnName("Name")
            .IsRequired();

        entity.Property(e => e.Price)
            .HasColumnName("Price")
            .IsRequired();

        entity.Property(e => e.Currency)
            .HasColumnName("Currency")
            .IsRequired();

        entity.Property(e => e.Description)
            .HasColumnName("Description")
            .IsRequired(false);

        entity.Property(e => e.Picture)
            .HasColumnName("Picture")
            .IsRequired(false);

        entity.Property(e => e.CreatedAt)
            .HasColumnName("CreatedAt")
            .IsRequired(false);

        entity.Property(e => e.UpdatedAt)
            .HasColumnName("UpdatedAt")
            .IsRequired(false);

        entity.HasOne(x => x.OsnastkaType)
            .WithMany(x => x.Osnastkas)
            .HasForeignKey(x => x.OsnastkaTypeId);
    }
}
