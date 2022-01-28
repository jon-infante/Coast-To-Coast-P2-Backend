using Models;
namespace DL;

public interface IRepo
{    
    void AddDrawing(Drawing drawingToAdd);

    Drawing GetDrawingByID(int DrawingID);
    
    List<Drawing> GetAllDrawingsByUserID(int UserID);
    
    List<Drawing> GetAllDrawingsByWallPostID(int WallPostID);

    void DeleteDrawingByID(int DrawingID);
}