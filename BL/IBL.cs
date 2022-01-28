using Models;
namespace BL;

public interface IBL
{    
    void AddDrawing(Drawing drawingToAdd);
    Drawing GetDrawingByID(int DrawingID);

    List<Drawing> GetAllDrawingsByUserID(int UserID);
    
    List<Drawing> GetAllDrawingsByWallPostID(int WallPostID);

    void DeleteDrawingByID(int DrawingID);

}
