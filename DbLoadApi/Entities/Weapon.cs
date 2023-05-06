using DbLoadApi.Entities.Base;
using DbLoadApi.Entities.Enums;

namespace DbLoadApi.Entities
{
    public class Weapon : IEntity<int>, IEnchantable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public WeaponType Type { get; set; }
        public virtual IEnumerable<Enchantment> Enchantments { get; set; }
    }
}