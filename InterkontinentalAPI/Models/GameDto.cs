namespace InterkontinentalAPI.Models
{
    public class GameDto
    {
        public string Start { get; set; }
        public string End { get; set; }
        public IEnumerable<CounterDto> Counters { get; set; } = new List<CounterDto>();
    }
}
