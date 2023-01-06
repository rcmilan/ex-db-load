namespace DbLoadApi.Entities.Base
{
    public interface IInventory
    {
        bool IsActive { get; set; }
    }

    public interface IInventory<Item> : IInventory where Item : IEntity
    {
        Item Inventory { get; set; }
    }
}