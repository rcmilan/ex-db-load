using DbLoadApi.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    var player = new Player
    {
        Id = 1,
        Health = 420,
        Job = DbLoadApi.Entities.Enums.PlayerJob.Warrior,
        Inventory = new List<PlayerInventory>
        {
            new PlayerInventory
            {
                IsActive= true,
                Item = new Weapon
                {
                    Id = 1,
                    Damage = 666,
                    Name = "Espada Top",
                    Type = DbLoadApi.Entities.Enums.WeaponType.Sword,
                    Enchantments = new List<Enchantment>
                    {
                        new Enchantment
                        {
                            Id = Guid.NewGuid(),
                            Type = DbLoadApi.Entities.Enums.EnchantmentType.Buff,
                            Description = "Ataque + 10"
                        },
                        new Enchantment
                        {
                            Id = Guid.NewGuid(),
                            Type = DbLoadApi.Entities.Enums.EnchantmentType.Debuff,
                            Description = "Ataque - 10"
                        }
                    }
                }
            }
        }
    };

    return player;
})
.WithName("Sample")
.WithOpenApi();

app.Run();