using System;

namespace Domain.AbilityScores;

public class AbilityScore
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Value { get; set; }
    public  int AbilityModifier => (Value - 10) / 2;
    // actual values - base value (10) / 2 to get bonus
      
}

public class AbilityScores
{
    public AbilityScore Strength { get; init; } 
    public AbilityScore Dexterity  { get; init; }
    public AbilityScore Constitution { get; init; }
    public AbilityScore Intelligence { get; init; }
    public AbilityScore Wisdom { get; init; }
    public AbilityScore Charisma { get; init; }
}

