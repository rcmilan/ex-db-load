using DbLoadApi.Configurations;
using DbLoadApi.Entities;
using DbLoadApi.Samples;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connString = builder.Configuration.GetConnectionString("DefaultConnection")!;

builder.Services.AddServices(connString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/player", async ([FromServices] MyDbContext dbContext, [FromQuery] int id) =>
{
    var player = await dbContext.Set<Player>()
        .FindAsync(id);

    return player;
})
.WithName("FindPlayer")
.WithOpenApi();

app.MapPost("/player", async ([FromServices] MyDbContext dbContext, [FromBody] Player player) =>
{
    await dbContext.Set<Player>()
        .AddAsync(player);

    await dbContext.SaveChangesAsync();

    return player;
})
.WithName("AddPlayer")
.WithOpenApi();

app.Run();