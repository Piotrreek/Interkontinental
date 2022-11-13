namespace InterkontinentalAPI.Entities
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<Counter> Counters { get; set; } = new List<Counter>();
    }
}
