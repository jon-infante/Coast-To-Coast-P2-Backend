namespace Models;
public class Drawing
{
        public Drawing(){}

        public int ID { get; set; }

        public int PlayerID { get; set; }

        public int WallPostID { get; set; }

        public string Category { get; set; }

        public string BucketImage { get; set; }

        public bool Guess { get; set; }

        public string GoogleResponse { get; set; }

        //each int is a user ID
        public List<Like> Likes { get; set; }

        public string Date { get; set; }

}

