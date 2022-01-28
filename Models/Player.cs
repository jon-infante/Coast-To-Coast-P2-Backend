namespace Models;
public class Player
{
        public Player(){}

        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int CorrectGuesses { get; set; }

        public int TotalGuesses { get; set; }
        //Top 5 results are produced when a guess is made, this is the average score 0-5
        public decimal AverageResult { get; set; }
        //A score is assigned to each of the top 5 results, ranging from 0-1
        public decimal AverageScore { get; set; }

        public List<Drawing> Drawings { get; set; }

}
