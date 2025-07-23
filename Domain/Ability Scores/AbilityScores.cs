using System;

namespace Domain.Abilities;

public class AbilityScore
{
    public int Id { get; init; } // will need it later for coupling in Persistence
    public required string Name { get; init; } // will need it later for serialisation
    public required int Value { get; set; }
    public int AbilityModifier => (int)Math.Floor((Value - 10) / 2.0);

    
    // actual values - base value (10) / 2 to get bonus
}

public class AbilityScores
{
    public required AbilityScore Strength { get; set; }
    public required AbilityScore Dexterity { get; set; }
    public required AbilityScore Constitution { get; set; }
    public required AbilityScore Intelligence { get; set; }
    public required AbilityScore Wisdom { get; set; }
    public required AbilityScore Charisma { get; set; }

    public AbilityScores(
        AbilityScore Strength,
        AbilityScore Dexterity,
        AbilityScore Constitution,
        AbilityScore Inteligence,
        AbilityScore Wisdom,
        AbilityScore Charisma)
    {
        if (AbilityScore.Value < 1 || AbilityScore.Value > 30)
            throw new ArgumentOutOfRangeException(nameof(AbilityScore)); 
    }
    
}

