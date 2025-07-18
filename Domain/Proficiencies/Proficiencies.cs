using System;
using Domain.Abilities;

namespace Domain.Proficiencies;

public class Proficiencies
{
   public int Id { get; init; } 
   public required string Name { get; init; } 

    public required ProficiencyType Type { get; init;  } 
    public required string Description { get; set; }
    public AbilityScore? GoverningAbility { get; set; } 
}

// do an enum for prof types
// do a class of type Proficiency for each type here