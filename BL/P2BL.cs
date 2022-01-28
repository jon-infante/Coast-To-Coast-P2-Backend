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

    public void AddWallpost(WallPost wallpostToAdd) {
        _dl.AddWallpost(wallpostToAdd);
    }

    public WallPost GetWallpostByID(int WallpostID) {
        return _dl.GetWallpostByID(WallpostID);
    }

    public List<WallPost> GetAllWallpostByCategoryID(int CategoryID) {
        return _dl.GetAllWallpostByCategoryID(CategoryID);
    }

    public WallPost GetWallpostByKeyword(string Key) {
        return _dl.GetWallpostByKeyword(Key);
    }

    public void DeleteWallpostByID(int WallpostID) {
        _dl.DeleteWallpostByID(WallpostID);
    }
}
