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

    //Likes
    public void AddLike(Like like)
    {
        _context.Add(like);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
    public Like GetLikeByID(int likeID)
    {
        return _context.Likes.FirstOrDefault(r => r.ID == likeID);
    }
    public List<Like> GetLikesByPlayerID(int playerID)
    {
        return _context.Likes.Where(l => l.PlayerID == playerID).ToList();
    }

    public List<Like> GetLikesByDrawingID(int drawingID)
    {
        return _context.Likes.Where(l => l.DrawingID == drawingID).ToList();
        
    }

    public List<Like> GetLikesByCommentID(int commentID)
    {
        return _context.Likes.Where(l => l.CommentID == commentID).ToList();
    }

    public void DeleteLikeByID (int likeID)
    {
        Like like = GetLikeByID(likeID);
        _context.Remove(like);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    //Comments
    public void AddComment(Comment commentToAdd){
        _context.Add(commentToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
    public Comment GetCommentByID(int commentID){
        return _context.Comments.Include(c => c.Likes).FirstOrDefault(r => r.ID == commentID);
    }
    public List<Comment> GetCommentsByDrawingID(int drawingID)
    {
        return  _context.Comments.Include(c => c.Likes).AsNoTracking().Where(c => c.DrawingID == drawingID).ToList();
    }

    public Comment EditCommentByID(int commentID, string message){
        Comment comment = GetCommentByID(commentID);
        comment.Message = message;
        _context.Update(comment);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return comment;
    }

    public void DeleteCommentByID(int commentID){
        Comment comment = GetCommentByID(commentID);
        _context.Remove(comment);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    //Categories
    public List<Category> GetAllCategories()
    {
        return _context.Categories.Include(r => r.WallPosts).Select(r => r).ToList();
    }
    public Category GetCategoryByID(int categoryID)
    {
        return _context.Categories.Include(r => r.WallPosts).FirstOrDefault(r => r.ID == categoryID);
    }
    public void AddCategory(Category catToAdd)
    {
        _context.Add(catToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();

    }
    public void DeleteCategory(int categoryID)
    {
        Category category = GetCategoryByID(categoryID);
        _context.Remove(category);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public List<Category> SearchCategories(string searchTerm)
    {
        return _context.Categories.Include(c => c.WallPosts).Where(x => x.CategoryName.ToLower().Contains(searchTerm.ToLower())).ToList();
    }
    //Drawings
    public void AddDrawing(Drawing drawingToAdd){
        _context.Add(drawingToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public void UpdateDrawing(Drawing drawingToUpdate){
        _context.Update(drawingToUpdate);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public Drawing GetDrawingByID(int DrawingID){
        return  _context.Drawings
        .Include(r => r.Likes)
        .FirstOrDefault(r => r.ID == DrawingID);
    }
    public List<Drawing> GetAllDrawings(){
        return _context.Drawings
        .Include(r => r.Likes)
        .AsNoTracking()
        .ToList();
    }
       
    public List<Drawing> GetAllDrawingsByPlayerID(int playerID){
        return _context.Drawings
        .Include(r => r.Likes)
        .AsNoTracking()
        .Where(r => r.PlayerID == playerID)
        .ToList();
    }   
    public List<Drawing> GetAllDrawingsByWallPostID(int WallPostID){
        return _context.Drawings
        .Include(r => r.Likes)
        .AsNoTracking()
        .Where(r => r.WallPostID == WallPostID)
        .ToList();
    }

    public void DeleteDrawingByID(int DrawingID){
        Drawing drawing = GetDrawingByID(DrawingID);
        _context.Remove(drawing);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
    //Wall Posts

    public List<WallPost> GetAllWallPosts(){
        return _context.WallPosts
        .Include(r => r.Drawings)
        .AsNoTracking()
        .Select(r => r)
        .ToList();
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
    
    //Players
    public void AddNewPlayerAccount(Player playerToAdd)
    {
        _context.Add(playerToAdd);
        _context.SaveChanges();
    }
    
    public Player? GetPlayerByIDWithDrawings(int playerID)
    {
        return _context.Players.Include(r => r.Drawings).FirstOrDefault(r => r.ID == playerID);
    }

    public Player? GetPlayerByUsernameWithDrawings(string username)
    {
        return _context.Players.Include(r => r.Drawings).FirstOrDefault(r => r.Username == username);
    }

    public void DeletePlayerByID(int playerID)
    {
        Player player = GetPlayerByIDWithDrawings(playerID);
        _context.Remove(player);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public List<Player> GetAllPlayersWithDrawings()
    {
        return _context.Players.Include(r => r.Drawings).AsNoTracking().Select(r => r).ToList();
    }

    /*    public Player LoginPlayer(string username, string password)
        {
            return _context.Players.FirstOrDefault(r => r.Username == username && r.Password == password);
        }*/

    public Player LoginPlayer(string username)
    {
        return _context.Players.Include(r => r.Drawings).FirstOrDefault(r => r.Username == username);
    }

    public bool IsDuplicate(Player player)
    {
        Player? dupe = _context.Players.FirstOrDefault(r => r.Username == player.Username);
        return dupe != null;
    }
}