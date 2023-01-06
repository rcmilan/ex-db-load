using DbLoadApi.Entities;

namespace DbLoadApi.Samples
{
    public static class PlayerSample
    {
        public static readonly Player Player = new()
        {
            Id = -1,
            Health = 420,
            Job = Entities.Enums.PlayerJob.Warrior,
            WeaponInventory = new List<PlayerWeaponInventory>
            {
                new PlayerWeaponInventory
                {
                    IsActive= true,
                    Inventory = new Weapon
                    {
                        Id = -1,
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
            },
            EquipmentInventory = new List<PlayerEquipmentInventory>
            {
                new PlayerEquipmentInventory
                {
                    Inventory = new Equipment
                    {
                        Id = 999,
                        Name = "Blusa com DRIP",
                        Resistance = 0,
                        Type = Entities.Enums.EquipmentType.Armor,
                        Enchantments = new List<Enchantment>
                        {
                            new Enchantment
                            {
                                Id = Guid.NewGuid(),
                                Description = "+ 10 de estilo",
                                Type = Entities.Enums.EnchantmentType.Buff
                            }
                        }
                    },
                    IsActive= true,
                }
            }
        };
    }
}