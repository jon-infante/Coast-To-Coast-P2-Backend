namespace Models;

public class Comment {
    public Comment(){}

    public int ID { get; set; }

    public int DrawingID { get; set; }

    public int UserID { get; set; }

    public string Username { get; set; }

    public string Message { get; set; }

    public List<Like> Likes { get; set; }

    public string Date { get; set; }

    public bool isLiked { get; set; }
}