namespace mvc_game.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalGamePlayed { get; set; }
        public int TotalScores { get; set; }
        public string Country { get; set; }
        public string GameType { get; set; }
    }
}