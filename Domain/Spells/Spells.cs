using System;
using Domain.Abilities;
using Domain.Enums;

namespace Domain.Spells;

public class Spell
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required SpellLevel Level { get; set; }
    public required string Effect { get; set; }
    public required SpellComponents Components { get; init; }
    public required string Range { get; set; }
    public required ActionType CastingTime { get; set; }
    public required string Duration { get; set; }
    public required string Target { get; set; }
    public required bool AOE { get; init; }
    public required bool SavingThrowNeeded { get; init; }
    public required bool AttackRollNeeded { get; init; }
    public required bool AdditionalUpcastEffect { get; init; }
    public required bool Concentration { get; init; }
    public required bool Ritual { get; init; }
    public required SpellSchool School { get; set; }
    public required SpellList CasterList { get; set; }

}