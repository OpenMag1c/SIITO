using DAL.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class AppDbContext : DbContext
{
    public DbSet<Instrument> Instruments { get; set; }
    public DbSet<InstrumentType> InstrumentTypes { get; set; }
    public DbSet<Gost> Gosts { get; set; }
    public DbSet<Osnastka> Osnastkas { get; set; }
    public DbSet<OsnastkaType> OsnastkaTypes { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(InstrumentConfig).Assembly);
    }
}
