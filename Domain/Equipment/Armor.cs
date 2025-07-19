using System;

namespace Domain.Equipment;

public class Armor
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; set; }
    public required int ACBonus { get; set; }
    public required bool Heavy { get; set; }
    public required bool Stealthy { get; set; }
    public required bool Shield { get; set; }
    public required ArmorType Type { get; set; }
    public required int Cost { get; set; }
    public required int StrengthRequirement { get; init; }
    public required int Weight { get; init; }
}

// do an enum for prof types
// do a class of type Proficiency for each type here

