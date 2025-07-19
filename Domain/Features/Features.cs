using System;

namespace Domain.Features;

public class Feature
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Requirement { get; set; }
}

// is it worth having a List object, of feats to store in the future to
// serialise as a drop down list on the front end?