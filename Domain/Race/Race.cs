using System;

namespace Domain.Race;

public class Race 
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required List<AbilityScoreModifier> AbilityScoreModifiers { get; set; } = []; // the [] makes it a new empty array if the list is empty. 
    // Usefull if race gives two different ASIs
    public required List<string> SuggestedAlignment { get; set; } = []; 
    public required string CreatureType { get; set; }
    public required string CreatureSize { get; set; }
    public List<Skill>? RacialSkills { get; set; } = [];
    public List<RacialFeature>? RacialFeatures { get; set; }
    public List<Proficiency>? RacialProficiencies { get; set; }
    public required List<Subrace> Subraces { get; set; } = [];
    public List<Spell>? RacialSpells { get; set; } = [];
}
