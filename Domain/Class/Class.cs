using System;
using Domain.CharacterProficiencies;
using Domain.Equipment;
using Domain.Features;

namespace Domain.Class;

public class CharacterClass
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int ClassLevel { get; set; }
    public required HitDie HitDice { get; init; }
    public int StartingHp { get; set; }
    public required Proficiency ClassProficiencies { get; set; }
    public required Feature ClassFeatures { get; set; }
    public required CharacterClass Subclasses { get; set; }
    public required CharacterEquipment StartingEquipment { get; set; }
}
