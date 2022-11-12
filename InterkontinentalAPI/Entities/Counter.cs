namespace InterkontinentalAPI.Entities
{
    public class Counter
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public Field Field { get; set; }
        public int FieldId { get; set; }
        public Game Game { get; set; }
        public int GameId { get; set; }
    }
}
