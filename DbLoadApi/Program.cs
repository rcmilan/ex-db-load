using DbLoadApi.Configurations;
using DbLoadApi.Samples;
using Microsoft.AspNetCore.Mvc;

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

app.MapGet("/sample", () =>
{
    return PlayerSample.Player;
})
.WithName("Sample")
.WithOpenApi();

app.MapGet("/player", ([FromQuery] int id) =>
{
    return "";
})
.WithName("Player")
.WithOpenApi();

app.Run();