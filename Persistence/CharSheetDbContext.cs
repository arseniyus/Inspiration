
using System;
using Domain;
using Domain.Character;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class CharSheetDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Character> Characters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Character>()
            .HasOne(c => c.Class)
            .WithMany();

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CharSheetDbContext).Assembly);
    }
}
