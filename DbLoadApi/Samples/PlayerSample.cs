using DbLoadApi.Entities;

namespace DbLoadApi.Samples
{
    public static class PlayerSample
    {
        public static readonly Player Player = new()
        {
            Id = 1,
            Health = 420,
            Job = Entities.Enums.PlayerJob.Warrior,
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
                        Type = Entities.Enums.WeaponType.Sword,
                        Enchantments = new List<Enchantment>
                        {
                            new Enchantment
                            {
                                Id = Guid.NewGuid(),
                                Type = Entities.Enums.EnchantmentType.Buff,
                                Description = "Ataque + 10"
                            },
                            new Enchantment
                            {
                                Id = Guid.NewGuid(),
                                Type = Entities.Enums.EnchantmentType.Debuff,
                                Description = "Ataque - 10"
                            }
                        }
                    }
                }
            }
        };
    }
}