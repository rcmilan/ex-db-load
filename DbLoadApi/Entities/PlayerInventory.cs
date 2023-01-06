using DbLoadApi.Entities.Base;

namespace DbLoadApi.Entities
{
    public class PlayerWeaponInventory : IEntity, IInventory<Weapon>
    {
        public Weapon Inventory { get; set; }
        public bool IsActive { get; set; }
    }
}