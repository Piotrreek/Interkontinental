namespace InterkontinentalAPI.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public bool HasEnded { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ICollection<Counter> Counters { get; set; } = new List<Counter>();
    }
}
