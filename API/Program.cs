using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain.Character;

var allowedSpecificOrigins = "_allowedSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowedSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:5173")
                                             .AllowAnyHeader()
                                             .AllowAnyMethod();
                      });
});

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<CharSheetDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("SupabasePostgresConnection"));

});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}                                                                                            

app.UseHttpsRedirection();

app.UseCors(allowedSpecificOrigins);

#region Test

app.MapGet("/", () => 
    Results.Redirect("/scalar/v1"));

#endregion

#region Character

app.MapGet("/characters", async (CharSheetDbContext db) =>
    await db.Characters.ToListAsync());

// Add an endpoint here for fetching all characters by playerId. 

app.MapGet("/characters/{Id}", async (string id, CharSheetDbContext db) =>
    await db.Characters.FindAsync(id)
        is Character character 
            ? Results.Ok(character)
            : Results.NotFound());

app.MapPost("/characters", async (CreateCharacterRequest character, CharSheetDbContext db) =>
{
    var pc = new Character(
            character.Name,
            character.Class,
            character.Level,
            character.Race,
            character.Background,
            character.Alignment ?? string.Empty,
            character.PersonalityTraits ?? string.Empty,
            character.Ideals ?? string.Empty,
            character.Bonds ?? string.Empty,
            character.Flaws ?? string.Empty,
            character.Age ?? 0,
            character.PhysicalDescription ?? string.Empty, 
            character.ExperiencePoints ?? 0
    );

    db.Characters.Add(pc);
    await db.SaveChangesAsync();

    return Results.Created($"/characters/{pc.Id}", pc);
});

app.MapPut("/characters/{Id}", async (string id, CreateCharacterRequest character, CharSheetDbContext db) =>
{
    var pc = await db.Characters.FindAsync(id);

    if (pc is null)
        return Results.NotFound();
    
    pc.Name = character.Name; 
    pc.ExperiencePoints = character.ExperiencePoints;
    pc.Class = character.Class;
    pc.Level = character.Level;
    pc.Race = character.Race;
    pc.Background = character.Background;
    pc.Alignment = character.Alignment;
    pc.PersonalityTraits = character.PersonalityTraits;
    pc.Ideals = character.Ideals;
    pc.Bonds = character.Bonds;
    pc.Flaws = character.Flaws;
    pc.Age = character.Age;
    pc.PhysicalDescription = character.PhysicalDescription;

    await db.SaveChangesAsync();

    return Results.NoContent();

});

app.MapDelete("/characters/{id}", async (string id, CharSheetDbContext db) =>
{
    if (await db.Characters.FindAsync(id) is Character character)
    {
        db.Characters.Remove(character);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});

#endregion

app.Run();

// provisionally place any DTOs here
#region DTOs

// The DTO (Data Transfer Object)
public class CreateCharacterRequest
{
    public required string Name { get; set; }
    public required string Class { get; set; }
    public required int Level { get; set; }
    public required string Race { get; set; }
    public required string Background { get; set; }
    public string? Alignment { get; set; }
    public string? PersonalityTraits { get; set; }
    public string? Ideals { get; set; }
    public string? Bonds { get; set; }
    public string? Flaws { get; set; }
    public int? Age { get; set; }
    public string? PhysicalDescription { get; set; }
    public int? ExperiencePoints { get; set; }
}

#endregion
