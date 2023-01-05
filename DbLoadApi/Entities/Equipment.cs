using DbLoadApi.Entities.Base;
using DbLoadApi.Entities.Enums;

namespace DbLoadApi.Entities
{
    public class Equipment : IEntity<int>, IEnchantable
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Resistance { get; set; }
        public EquipmentType Type { get; set; }
        public IEnumerable<Enchantment> Enchantments { get; set; }
    }
}