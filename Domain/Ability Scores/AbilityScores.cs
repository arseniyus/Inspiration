using System;

namespace Domain.Abilities;

public class AbilityScore
{
    public int Id { get; init; } // will need it later for coupling in Persistence
    public required string Name { get; init; } // will need it later for serialisation
    private int _value = 1;
    public required int Value
    {
        get => _value;
        set
        {
            if ((value > 0) && (value < 31))
            {
                _value = value;
            }
        }
    }
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

    
}

