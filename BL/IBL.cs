using Models;
namespace BL;

public interface IBL
{   
    List<Category> GetAllCategories();
    Category GetCategoryById(int ID);
    void AddCategory(Category catToAdd);
    void DeleteCategory(Category catToDelete);
    List<Category> SearchCategories(string searchTerm);


    void AddDrawing(Drawing drawingToAdd);
    Drawing GetDrawingByID(int DrawingID);

    List<Drawing> GetAllDrawingsByUserID(int UserID);
    
    List<Drawing> GetAllDrawingsByWallPostID(int WallPostID);

    void DeleteDrawingByID(int DrawingID);

    void AddWallpost(WallPost wallpostToAdd);
    WallPost GetWallpostByID(int WallpostID);

    List<WallPost> GetAllWallpostByCategoryID(int CategoryID);

    WallPost GetWallpostByKeyword(string Key);

    void DeleteWallpostByID(int WallpostID);

    Player AddNewPlayerAccount(Player playerToAdd);
    List<Player> GetAllPlayers();
    Task<List<Player>> GetAllPlayersWithDrawingsAsync();
    Player GetPlayerByID(int PlayerID);
    Task<Player> GetPlayerByIDWithDrawingsAsync(int PlayerID);
    void DeletePlayerByID(int PlayerID);

}
