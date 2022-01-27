namespace Models;

public class Comment {
    public Comment(){}

    public int ID { get; set; }

    public int DrawingID { get; set; }

    public int UserID { get; set; }

    //Each int is a user ID
    public List<int> Likes { get; set; }

    public string Date { get; set; }
}