namespace Models;
public class Player
{
        public Player(){}

        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int CorrectGuesses { get; set; }
        public decimal Score { get; set; }

        public List<Drawing> Drawings { get; set; }

}
