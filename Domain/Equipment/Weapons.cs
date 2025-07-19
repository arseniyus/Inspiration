using System;
using Domain.Enums;

namespace Domain.Equipment;

public class Weapons
{
    public required WeaponType WeaponType { get; set; }
    public required WeaponProperty WeaponProperties { get; set; }
    public required string Cost { get; set; }
    public required Dice Damage { get; set; }
    public required int Weight { get; set; }
    public bool? Improvised { get; init; }
    public bool? Silvered { get; set; }
    public bool? Special { get; init; }
    public bool? MagicWeapon { get; set; }
}
