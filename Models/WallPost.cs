namespace Models;

public class WallPost{

    public WallPost(){}

    public int ID { get; set; }

    public int CategoryID { get; set; }

    public string Keyword { get; set; }

    public List<Drawing> Drawings { get; set; }

}