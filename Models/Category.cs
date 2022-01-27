namespace Models;

public class Category{

    public Category(){}

    public int ID { get; set; }

    public string CategoryName { get; set; }

    public List<WallPost> WallPosts { get; set; }
}