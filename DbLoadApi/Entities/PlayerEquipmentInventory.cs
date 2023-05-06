using DbLoadApi.Entities.Base;

namespace DbLoadApi.Entities
{
    public class PlayerEquipmentInventory : IEntity, IInventory<Equipment>
    {
        public virtual Equipment Inventory { get; set; }
    }
}