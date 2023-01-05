using DbLoadApi.Entities.Base;
using DbLoadApi.Entities.Enums;

namespace DbLoadApi.Entities
{
    public class Equipment : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Resistance { get; set; }
        public EquipmentType Type { get; set; }
    }
}