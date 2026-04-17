using System;

namespace Domain.Class;

public class CharacterClassProgression
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public int CharacterClassId { get; set; }
    public int LevelInClass { get; set; }
    public int? SubclassId { get; set; }

}
