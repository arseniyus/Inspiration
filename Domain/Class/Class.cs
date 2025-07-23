using System;
using Domain.CharacterProficiencies;
using Domain.Equipment;
using Domain.Features;

namespace Domain.Class;

public class CharacterClass
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required int ClassLevel { get; set; }
    public required HitDie HitDice { get; init; }
    public int StartingHp { get; set; }
    public required Proficiency ClassProficiencies { get; set; }
    public required Feature ClassFeatures { get; set; }
    public  Subclass? Subclasses { get; set; }
    public required CharacterEquipment StartingEquipment { get; set; }
}

public class Subclass : CharacterClass
{
    public int SubclassId { get; init; }
    public required string SubclassName { get; init; }
    public int ClassLevel { get; set; }
    public Proficiency? ClassProficiencies { get; set; }
    public Feature? ClassFeatures { get; set; }
}
