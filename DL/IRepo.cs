using Models;
namespace DL;

public interface IRepo
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
}