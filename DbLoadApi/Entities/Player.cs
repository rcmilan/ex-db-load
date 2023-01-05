using DbLoadApi.Entities.Base;
using DbLoadApi.Entities.Enums;

namespace DbLoadApi.Entities
{
    public class Player : IEntity<int>
    {
        public int Id { get; set; }
        public int Health { get; set; }
        public PlayerJob Job { get; set; }
        public IEnumerable<PlayerInventory> Inventory { get; set; }
        public IEnumerable<IEntity> ActiveItems => Inventory.Where(i => i.IsActive);
    }
}