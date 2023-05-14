using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class GostConfig : IEntityTypeConfiguration<Gost>
{
    public void Configure(EntityTypeBuilder<Gost> entity)
    {
        entity.ToTable("Gost");

        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("GostId");

        entity.Property(e => e.Name)
            .HasColumnName("Name")
            .IsRequired();

        entity.Property(e => e.Link)
            .HasColumnName("Link")
            .IsRequired();

        entity.Property(e => e.CreatedAt)
            .HasColumnName("CreatedAt")
            .IsRequired(false);

        entity.Property(e => e.UpdatedAt)
            .HasColumnName("UpdatedAt")
            .IsRequired(false);
    }
}
