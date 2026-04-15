using Microsoft.EntityFrameworkCore;
using Persistence;
var builder = WebApplication.CreateBuilder(args);

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
}
                                                                                                 

app.UseHttpsRedirection();


app.Run();
