using System;
using Domain.CharacterRace;
using Domain.Abilities;
using Domain.CharacterSkills;
using Domain.CharacterProficiencies;
using Domain.Class;
using Domain.Spells;
using Domain.Features;
using Domain.Equipment;
using Domain.Backgrounds;

namespace Domain;

public class Character
{
    public required int Id { get; init; } = 0;
    public string? Name { get; set; } = string.Empty;
    public required Race Race { get; set; }
    public required CharacterClass Class { get; set; }
    public required bool MultiClass { get; set; } = false;
    public required int CharacterLevel { get; set; }

    public int ProficiencyBonus => CharacterProficiencyBonus(CharacterLevel); // function call of calculated prof. => is a Lambda operator, shorter anon functions 
    private int CharacterProficiencyBonus(int CharacterLevel) => CharacterLevel switch
    {
        <= 4 => 2,
        <= 8 => 3,
        <= 12 => 4,
        <= 16 => 5,
        <= 20 => 6,
        _ => throw new ArgumentNullException(nameof(CharacterLevel), "Level must be 1-20")
        // this is a switch expression, more concise than prebious if/else,
    };

    public required AbilityScores AbilityScores { get; set; }
    public required Background Background { get; init; }
    public required CharacterEquipment Equipment { get; set; }
    public Spell? Spells { get; set; }
    public required Feature Features { get; set; }
    public string? Biography { get; set; } = string.Empty;
    public required Proficiencies Proficiencies { get; set; }
    public required Skill Skills { get; set; }
    public int HP { get; set; } = 0;
    public int AC { get; set; } = 10;
    public int PlayerId { get; init; } = 0;
    public string? PlayerName { get; set; } = string.Empty;

}
