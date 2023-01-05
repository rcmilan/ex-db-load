namespace DbLoadApi.Entities
{
    public class Equipment : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Defense { get; set; }
    }
}