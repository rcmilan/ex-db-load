using DbLoadApi.Entities.Base;
using DbLoadApi.Entities.Enums;

namespace DbLoadApi.Entities
{
    public class Enchantment : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Description { get; set; }
        public EnchantmentType Type { get; set; }
    }
}