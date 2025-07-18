using System;
using Domain.Abilities;

namespace Domain.CharacterSkills;

public class Skill
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required AbilityScore GoverningAbility { get; set; }
    public required string Description { get; set; } 
}
