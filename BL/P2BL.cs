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

    public List<Category> GetAllCategories()
    {
        return _dl.GetAllCategories();
    }

    public Category GetCategoryById(int ID)
    {
        return _dl.GetCategoryById(ID);
    }

    public void AddCategory(Category catToAdd)
    {
        _dl.AddCategory(catToAdd);
    }

    public void DeleteCategory(Category catToDelete)
    {
        _dl.DeleteCategory(catToDelete);
    }

    public List<Category> SearchCategories(string searchTerm)
    {
        return _dl.SearchCategories(searchTerm);

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
