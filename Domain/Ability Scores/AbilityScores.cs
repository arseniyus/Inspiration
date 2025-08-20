using System;
namespace Domain.Abilities;

public class AbilityScore
{
    public AbilityType Ability { get; init; }
    private readonly List<AbilityModifier> _modifiers = [];
    public int BaseValue
    {
        get => _basevalue;
        private set => _basevalue = value; 
    }
    private int _basevalue;

    public void SetBaseValue(int value)
    {
        if (value is < 1 or > 30)
            throw new ArgumentOutOfRangeException(nameof(value), "Must be between 1 - 30");

        _basevalue = value;
    }
    public AbilityScore(int value)
    {
        SetBaseValue(value);
    }

    private AbilityScore() { }
    public int Value => _basevalue + _modifiers.Sum(m => m.Value);

    public void AddModifier(AbilityModifier modifier) => _modifiers.Add(modifier);
    public void RemoveModifier(AbilityModifier modifier) => _modifiers.Remove(modifier);
    public int AbilityScoreModifier => (int)Math.Floor((Value - 10) / 2.0);

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

public class AbilityModifier
{
    public string Source { get; init;  } = string.Empty;
    public int Value { get; init; }
}


