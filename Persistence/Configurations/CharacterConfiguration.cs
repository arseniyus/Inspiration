using System;
using Domain.Character;
using Domain.Abilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

/* public class CharacterConfiguration : IEntityTypeConfiguration<Character>
{
    public void Configure(EntityTypeBuilder<Character> builder)
    {
        builder.ToTable("Character");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Name).HasMaxLength(100);

        builder.HasOne(c => c.Class).WithMany();
        builder.HasOne(c => c.Race).WithMany();

        builder.OwnsOne(c => c.AbilityScores, scores =>
        {
            scores.OwnsOne(s => s.Strength, a =>
            {
                a.Property(p => p.BaseValue).HasColumnName("Strength");
            });
            scores.OwnsOne(s => s.Dexterity, a =>
            {
                a.Property(p => p.BaseValue).HasColumnName("Dexterity");
            });
            scores.OwnsOne(s => s.Constitution, a =>
            {
                a.Property(p => p.BaseValue).HasColumnName("Constitution");
            });
            scores.OwnsOne(s => s.Intelligence, a =>
            {
                a.Property(p => p.BaseValue).HasColumnName("Intelligence");
            });
            scores.OwnsOne(s => s.Wisdom, a =>
            {
                a.Property(p => p.BaseValue).HasColumnName("Wisdom");
            });
            scores.OwnsOne(s => s.Charisma, a =>
            {
                a.Property(p => p.BaseValue).HasColumnName("Charisma");
            });
        });
    }
}
 */