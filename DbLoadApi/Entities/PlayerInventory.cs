using DbLoadApi.Entities.Base;

namespace DbLoadApi.Entities
{
    public class PlayerInventory : IEntity
    {
        public IEntity Item { get; set; }
        public bool IsActive { get; set; }
    }
}