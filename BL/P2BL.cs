using Models;
using DL;

namespace BL;
public class P2BL : IBL
{
    private IRepo _dl;

    public P2BL(IRepo repo)
    {
        _dl = repo;
    }
    public void AddDrawing(Drawing drawingToAdd){
        _dl.AddDrawing(drawingToAdd);
    }


    public Drawing GetDrawingByID(int DrawingID){
        return _dl.GetDrawingByID(DrawingID);
        
    }

    public List<Drawing> GetAllDrawingsByUserID(int UserID){
        return _dl.GetAllDrawingsByUserID(UserID);
    }
    public List<Drawing> GetAllDrawingsByWallPostID(int WallPostID){
        return _dl.GetAllDrawingsByWallPostID(WallPostID);
    }

    public void DeleteDrawingByID(int DrawingID){
        _dl.DeleteDrawingByID(DrawingID);
    }

}
