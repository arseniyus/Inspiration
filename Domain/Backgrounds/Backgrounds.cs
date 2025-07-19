using System;
using Domain.CharacterProficiencies;
using Domain.Equipment;
using Domain.Features;

namespace Domain.Backgrounds;

public class Background
{
    public required int Id { get; init; }
    public required string Name { get; set; }
    public required Proficiency BackgroundProficiency { get; set; }
    public required CharacterEquipment BackgroundEquipment { get; set; }
    public required Feature BackgroundFeature { get; set; }
    public List<string>? SuggestedCharacteristics { get; set; }
}
