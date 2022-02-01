namespace Models;
public class Drawing
{
        public Drawing(){}

        public int ID { get; set; }

        public int PlayerID { get; set; }

        public int WallPostID { get; set; }

        public string Keyword { get; set; }

        public string BucketImage { get; set; }

        public bool Guess { get; set; }

        public decimal GoogleScore { get; set; }

        public string GoogleResponse { get; set; }

        public List<Like> Likes { get; set; }

        public string Date { get; set; }

}

