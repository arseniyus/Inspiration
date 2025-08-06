
using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class CharSheetDbContext (DbContextOptions options) : DbContext(options)
{
    public required DbSet<Character> Characters { get; set; }
}
