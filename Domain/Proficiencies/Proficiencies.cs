using System;
using Domain.Abilities;
using Domain.Enums;

namespace Domain.CharacterProficiencies;

public class Proficiency
{
    public int Id { get; init; }
    public required string Name { get; init; }

    public required ProficiencyType Type { get; init; }
    public required string Description { get; set; }
    public AbilityScore? GoverningAbility { get; set; }
}

// do an enum for prof types
// do a class of type Proficiency for each type here

public class Proficiencies
{
    public required List<Proficiency> AllProficiencies { get; set; } = [];

}

// does it need to know what weapon proficiency contain at this stage? 
// e.g. weapon proficiency, simple, martial, weapon properties, etc
// maybe rather than an enum I need to make a class for each type 
//can I make it of type proficiency?
