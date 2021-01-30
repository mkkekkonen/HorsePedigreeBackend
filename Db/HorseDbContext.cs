using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using horsesBackend.Models;

namespace horsesBackend.Db
{
  public class HorseDbContext : DbContext
  {
    public DbSet<Horse> Horses { get; set; }
    public DbSet<Breed> Breeds { get; set; }

    public HorseDbContext(DbContextOptions<HorseDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      modelBuilder.Entity<Horse>().HasOne(horse => horse.Breed)
        .WithMany(breed => breed.Horses);

      modelBuilder.Entity<Horse>().HasOne(horse => horse.Dam);

      modelBuilder.Entity<Horse>().HasOne(horse => horse.Sire);
    }
  }
}
