namespace mvc_game.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalGamePlayed { get; set; }
        public int TotalScores { get; set; }
    }
}