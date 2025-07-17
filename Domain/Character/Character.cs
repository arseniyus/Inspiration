using System;
using Domain.AbilityScores;

namespace Domain;

public class Character
{
    public required int Id { get; set; } = 0; 
    public string? Name { get; set; } = string.Empty;
    public Race Race { get; set; }
    public Class Class { get; set; }
    public required int CharacterLevel { get; set; }

    public int ProficiencyBonus => CharacterProficiencyBonus(CharacterLevel); // function call of calculated prof. => is a Lambda operator, shorter anon functions 
    private int CharacterProficiencyBonus(int CharacterLevel)
    {
        var proficiencyBonus = 0;
        if (CharacterLevel <= 4)
        {
            proficiencyBonus = 2;
        }
        else if (CharacterLevel <= 8 && CharacterLevel > 4)
        {
            proficiencyBonus = 3;
        }
        else if (CharacterLevel <= 12 && CharacterLevel > 8)
        {
            proficiencyBonus = 4;
        }
        else if (CharacterLevel <= 16 && CharacterLevel > 12)
        {
            proficiencyBonus = 5;
        }
        else if (CharacterLevel <= 20 && CharacterLevel > 16)
        {
            proficiencyBonus = 6;
        }
        return proficiencyBonus;
    }
    
    public AbilityScores AbilityScores { get; set; }
    public Background Background { get; set; }
    public List<string>? Equipment { get; set; }
    public Spells? Spells { get; set; }
    public Features Features { get; set; }
    public string? Biography { get; set; } = string.Empty;
    public Proficiencies Proficiencies { get; set; }
    public Skills Skills { get; set; }
    public int HP { get; set; } = 0;
    public int AC { get; set; } = 10; 
    public int PlayerId { get; set; } = 0;
    public string? PlayerName { get; set; } = string.Empty;

}
