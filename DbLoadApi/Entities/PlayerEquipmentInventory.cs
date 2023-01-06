using DbLoadApi.Entities.Base;

namespace DbLoadApi.Entities
{
    public class PlayerEquipmentInventory : IEntity, IInventory<Equipment>
    {
        public Equipment Inventory { get; set; }
        public bool IsActive { get; set; }
    }
}