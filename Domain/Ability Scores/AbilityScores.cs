using System;
namespace Domain.Abilities;

public class AbilityScore
{
    private int _value;
    public AbilityScore(int value)
    {
        if (value is < 1 or > 30)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Must be between 1 - 30");

        }
        _value = value;
    }
    public int Value => _value;
    public int AbilityModifier => (int)Math.Floor((Value - 10) / 2.0);

}

public class AbilityScores
{
    public AbilityScore Strength { get; set; } = new(10);
    public AbilityScore Dexterity { get; set; } = new(10);
    public AbilityScore Constitution { get; set; } = new(10);
    public AbilityScore Intelligence { get; set; } = new(10);
    public AbilityScore Wisdom { get; set; } = new(10);
    public AbilityScore Charisma { get; set; } = new(10);

    public AbilityScore this[AbilityType type] => type switch
    {
        AbilityType.Strength => Strength,
        AbilityType.Dexterity => Dexterity,
        AbilityType.Constitution => Constitution,
        AbilityType.Intelligence => Intelligence,
        AbilityType.Wisdom => Wisdom,
        AbilityType.Charisma => Charisma,
        _ => throw new ArgumentOutOfRangeException(nameof(type), "Invalid ability score")
    };
}


