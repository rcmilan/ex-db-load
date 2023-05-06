namespace DbLoadApi.Entities.Base
{
    public interface IInventory<Item> where Item : IEntity
    {
        Item Inventory { get; set; }
    }
}