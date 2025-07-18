using System;

namespace Domain.Abilities;

public class AbilityScore
{
    public int Id { get; init; } // will need it later for coupling in Persistence
    public required string Name { get; init; } // will need it later for serialisation
    public int Value { get; set; }
    public  int AbilityModifier => (int)Math.Floor((Value - 10) / 2.0);
    // actual values - base value (10) / 2 to get bonus
}

public class AbilityScores
{
    public required AbilityScore Strength { get; set; } 
    public required AbilityScore Dexterity  { get; set; }
    public required AbilityScore Constitution { get; set; }
    public required AbilityScore Intelligence { get; set; }
    public required AbilityScore Wisdom { get; set; }
    public required AbilityScore Charisma { get; set; }
}

