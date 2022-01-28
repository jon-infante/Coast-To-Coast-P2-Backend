using Models;
using Microsoft.EntityFrameworkCore;

namespace DL;

public class EFRepo : IRepo
{
    private DBContext _context;
    
    public EFRepo(DBContext context)
    {
        _context = context;
    }


    public Player AddNewPlayerAccount(Player playerToAdd)
    {
        _context.Add(playerToAdd);
        _context.SaveChanges();

        return playerToAdd;
    }
    
    public List<Category> GetAllCategories()
    {
        return _context.Categories.Include(r => r.WallPosts).Select(r => r).ToList();
    }
    public Category GetCategoryById(int ID)
    {
        return _context.Categories.Include(r => r.WallPosts).FirstOrDefault(r => r.ID == ID);
    }
    public void AddCategory(Category catToAdd)
    {
        _context.Add(catToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
    public void DeleteCategory(Category catToDelete)
    {
        _context.Remove(catToDelete);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public List<Category> SearchCategories(string searchTerm)
    {
        return _context.Categories.Where(x => x.CategoryName.ToLower().Contains(searchTerm.ToLower())).ToList();
    }
     
    public void AddDrawing(Drawing drawingToAdd){
        _context.Add(drawingToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public Drawing GetDrawingByID(int DrawingID){
        return  _context.Drawings
        .Include(r => r.Likes)
        .FirstOrDefault(r => r.ID == DrawingID);
    }
       
    public List<Drawing> GetAllDrawingsByUserID(int PlayerID){
        return _context.Drawings
        .Include(r => r.Likes)
        .AsNoTracking()
        .Where(r => r.PlayerID == PlayerID)
        .ToList();
        // return new List<Drawing>();
    }   
    public List<Drawing> GetAllDrawingsByWallPostID(int WallPostID){
        return _context.Drawings
        .Include(r => r.Likes)
        .AsNoTracking()
        .Where(r => r.WallPostID == WallPostID)
        .ToList();
        // return new List<Drawing>();
    }

    public void DeleteDrawingByID(int DrawingID){
        Drawing drawing = GetDrawingByID(DrawingID);
        _context.Remove(drawing);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public void AddWallpost(WallPost wallpostToAdd) {
        _context.Add(wallpostToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public WallPost GetWallpostByID(int WallpostID) {
        return _context.WallPosts.Include(r => r.Drawings).AsNoTracking().FirstOrDefault(r => r.ID == WallpostID);
    }

    public List<WallPost> GetAllWallpostByCategoryID(int CategoryID) {
        return _context.WallPosts.Include(r => r.Drawings).AsNoTracking().Where(r => r.CategoryID == CategoryID).ToList();
    }

    public WallPost GetWallpostByKeyword(string Key) {
        return _context.WallPosts.Include(r => r.Drawings).AsNoTracking().FirstOrDefault(r => r.Keyword == Key);
    }

    public void DeleteWallpostByID(int WallpostID) {
        WallPost wallpost = GetWallpostByID(WallpostID);
        _context.Remove(wallpost);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
}