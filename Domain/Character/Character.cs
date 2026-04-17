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
using System.Diagnostics.CodeAnalysis;

namespace Domain.Character;

public class Character
{
    public string Id { get; init; } = Guid.NewGuid().ToString();

        private int _experience; 
        private int _level; 
    public required string Name { get; set; }
   
    public int? ExperiencePoints 
    {
        get
        {
            return _experience; 
        }
        set
        {
            if (value < 0)
            {
                _experience = 0;
            }
            else 
                _experience = value ?? 0;
        }
    }
    public required string Class {get; set; }
    public required int Level 
    {
        get 
        { 
            return _level; 
        }
        set
        {
            if (value < 0)
            {
                return;
            }
            else if (value > 20)
            {
                return;
            }
            else 
                _level = value;
        }
    }
    public required string  Race {get; set; } 
    public required string Background {get; set; }
    public string?  Alignment {get; set; } = "";
    public string?  PersonalityTraits {get; set; } = "";
    public string?  Ideals {get; set; } = "";
    public string?  Bonds {get; set; } = "";
    public string?  Flaws {get; set; } = "";
    public int?  Age {get; set; } = null;
    public string?  PhysicalDescription {get; set; } = "";

    
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    [SetsRequiredMembers]
    private Character() {}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    [SetsRequiredMembers]
    public Character (string name, string characterClass, int lvl, string race, 
    string background, string alignment, string traits, string ideals, 
    string bonds, string flaws, int age, string description,  int xp = 0)
    {
        Name = name;
        Class = characterClass;
        Level = lvl;
        Race = race;
        Background = background;
        Alignment = alignment;
        PersonalityTraits = traits; 
        Ideals = ideals;
        Bonds = bonds;
        Flaws = flaws;
        Age = age;
        PhysicalDescription = description;
        ExperiencePoints = xp;
    }

    // public required Race Race { get; set; }
    // public required CharacterClass Class { get; set; }
    // public bool MultiClass { get; set; } = false;
    // public List<CharacterClassProgression> CharacterProgression = [];
    // public int CharacterLevel => CharacterProgression.Sum(c => c.LevelInClass);
    // public int ProficiencyBonus => CharacterProficiencyBonus(CharacterLevel); // function call of calculated prof. => is a Lambda operator, shorter anon functions 
    // private int CharacterProficiencyBonus(int CharacterLevel) => CharacterLevel switch
    // {
    //     <= 4 => 2,
    //     <= 8 => 3,
    //     <= 12 => 4,
    //     <= 16 => 5,
    //     <= 20 => 6,
    //     _ => throw new ArgumentNullException(nameof(CharacterLevel), "Level must be 1-20")
    //     // this is a switch expression, more concise than prebious if/else,
    // };

    // public required List<AbilityScore> AbilityScores { get; set; } = [];
    // public required Background Background { get; init; }
    // public required CharacterEquipment Equipment { get; set; }
    // public Spell? Spells { get; set; }
    // public required Feature Features { get; set; }
    // public string? Biography { get; set; } = string.Empty;
    // public required Proficiencies Proficiencies { get; set; }
    // public required Skill Skills { get; set; }
    // public int HP { get; set; } = 0;
    // public int AC { get; set; } = 10;
    // public int PlayerId { get; init; } = 0;
    // public string? PlayerName { get; set; } = string.Empty;
}