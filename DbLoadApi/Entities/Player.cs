using DbLoadApi.Entities.Base;
using DbLoadApi.Entities.Enums;

namespace DbLoadApi.Entities
{
    public class Player : IEntity<int>
    {
        public int Id { get; set; }
        public PlayerJob Job { get; set; }
    }
}