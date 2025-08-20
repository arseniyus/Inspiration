using System;
namespace Domain.Abilities;

public class AbilityScore
{
    private AbilityScore() { }
    public AbilityScore(AbilityType ability, int baseValue)
    {
        Ability = ability;
        BaseValue = baseValue;
    }
    public AbilityType Ability { get; private set; }
    public int BaseValue { get; private set; }
    private readonly List<int> _modifiers = [];
  
    public int Value => BaseValue + _modifiers.Sum();
    public void SetBaseValue(int value)
    {
        if (value is < 1 or > 30)
            throw new ArgumentOutOfRangeException(nameof(value), "Must be between 1 - 30");

        BaseValue = value;
    }
    public AbilityScore(int value)
    {
        SetBaseValue(value);
    }
    public void UpdateBaseValue(int newValue) => BaseValue = newValue;
    public void AddModifier(int value ) => _modifiers.Add(value);
    public void RemoveModifier(int value) => _modifiers.Remove(value);
    public int AbilityScoreModifier => (int)Math.Floor((Value - 10) / 2.0);

}

public class AbilityScores
{
    private AbilityScores() { }

    public AbilityScores WithDefaults() =>
        new AbilityScores
        {
            Strength = new AbilityScore(AbilityType.Strength, 10),
            Dexterity = new AbilityScore(AbilityType.Dexterity, 10),
            Constitution = new AbilityScore(AbilityType.Constitution, 10),
            Intelligence = new AbilityScore(AbilityType.Intelligence, 10),
            Wisdom = new AbilityScore(AbilityType.Wisdom, 10),
            Charisma = new AbilityScore(AbilityType.Charisma, 10),

        };
    public AbilityScore Strength { get; private set; }
    public AbilityScore Dexterity { get; private set; }
    public AbilityScore Constitution { get; private set; }
    public AbilityScore Intelligence { get; private set; }
    public AbilityScore Wisdom { get; private set; }
    public AbilityScore Charisma { get; private set; }
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




