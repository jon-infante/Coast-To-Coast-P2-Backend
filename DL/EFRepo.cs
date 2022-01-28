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

    public void AddDrawing(Drawing drawingToAdd){
        _context.Add(drawingToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public Drawing GetDrawingByID(int DrawingID){
        return  _context.Drawings
        .Include("Likes")
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