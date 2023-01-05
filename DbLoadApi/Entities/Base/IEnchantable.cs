namespace DbLoadApi.Entities.Base
{
    public interface IEnchantable
    {
        public IEnumerable<Enchantment> Enchantments { get; set; }
    }
}