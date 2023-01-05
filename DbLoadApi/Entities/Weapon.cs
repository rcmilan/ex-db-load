namespace DbLoadApi.Entities
{
    public class Weapon : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
    }
}
