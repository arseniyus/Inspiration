using System;

namespace Domain.Class;

public class Class
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int ClassLevel { get; set; }
    public required HitDie HitDice { get; init; }
    public int StartingHp { get; set; }
    public required List<Proficiency> ClassProficiencies { get; set; }
    public required List<ClassFeature> ClassFeatures { get; set; }
    public List<Subclass>? Subclasses { get; set; }
    public required List<Equipment> StartingEquipment { get; set; }
}
