using DbLoadApi.Entities.Base;

namespace DbLoadApi.Entities
{
    public class PlayerWeaponInventory : IEntity, IInventory<Weapon>
    {
        public virtual Weapon Inventory { get; set; }
    }
}