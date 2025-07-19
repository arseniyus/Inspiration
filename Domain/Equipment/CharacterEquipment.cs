using System;

namespace Domain.Equipment;

public class CharacterEquipment
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; set; }
    public required EquipmentType Type { get; set; }
    public required bool StartingEquipment { get; set; }
    public required string Cost { get; set; }
    public required int Weight { get; set; }
}

public class Equip
{
    public required List<CharacterEquipment> AllEquipment { get; set; } = [];

}