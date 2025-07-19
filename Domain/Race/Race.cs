using System;
using Domain.Abilities;
using Domain.CharacterProficiencies;
using Domain.CharacterSkills;
using Domain.Enums;
using Domain.Features;
using Domain.Spells;

namespace Domain.CharacterRace;

public class Race
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required AbilityScores RacialAbilityScoreIncrease { get; set; }
    // each race gets a +2 or +1 to Abilites, depends on race
    // coupling can wait until Persistence race id => ability.value + x
    // do I however couple racial bonuses to Domain abilities? Leaning towards yes. 
    public required Allignment SuggestedAlignment { get; set; }
    public required Creatures CreatureType { get; set; }
    public required Size CreatureSize { get; set; }
    public required int Speed { get; set; }
    public Skill? RacialSkills { get; set; }
    public Feature? RacialFeature { get; set; }
    public required Proficiencies RacialProficiencies { get; set; }
    public required Race Subrace { get; init; }
    public Spell? RacialSpells { get; set; }
}
