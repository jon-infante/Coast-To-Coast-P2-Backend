using Models;
using DL;
using CustomExceptions;
namespace BL;

public class P2BL : IBL
{
    private IRepo _dl;
    public P2BL(IRepo repo) {
        _dl = repo;
    }

    public void AddLike(Like like){
        _dl.AddLike(like);
    }

    public Like GetLikeByID(int likeID){
        return _dl.GetLikeByID(likeID);
    }

    public List<Like> GetLikesByPlayerID(int playerID){
        return _dl.GetLikesByPlayerID(playerID);
    }

    public List<Like> GetLikesByDrawingID(int drawingID){
        return _dl.GetLikesByDrawingID(drawingID);
    }

    public List<Like> GetLikesByCommentID(int commentID){
        return _dl.GetLikesByCommentID(commentID);
    }

    public void DeleteLikeByID (int likeID){
        _dl.DeleteLikeByID(likeID);
    }

    //Comments
    public void AddComment(Comment commentToAdd){
        _dl.AddComment(commentToAdd);
    }

    public Comment GetCommentByID(int commentID){
        return _dl.GetCommentByID(commentID);
    }

    public List<Comment> GetCommentsByDrawingID(int drawingID){
        return _dl.GetCommentsByDrawingID(drawingID);
    }

    public Comment EditCommentByID(int commentID, string message){
        return _dl.EditCommentByID(commentID, message);
    }

    public void DeleteCommentByID(int commentID){
        _dl.DeleteCommentByID(commentID);
    }

    //Categories
    public List<Category> GetAllCategories(){
        return _dl.GetAllCategories();
    }

    public Category GetCategoryByID(int categoryID){
        return _dl.GetCategoryByID(categoryID);
    }
    public void AddCategory(Category catToAdd){
        _dl.AddCategory(catToAdd);
    }

    public void DeleteCategory(int categoryID){
        _dl.DeleteCategory(categoryID);
    }

    public List<Category> SearchCategories(string searchTerm){
        return _dl.SearchCategories(searchTerm);
    }

    //Drawings
    public void AddDrawing(Drawing drawingToAdd){
        _dl.AddDrawing(drawingToAdd);
    }
    public void UpdateDrawing(Drawing drawingToUpdate){
        _dl.UpdateDrawing(drawingToUpdate);
    }


    public Drawing GetDrawingByID(int drawingID){
        return _dl.GetDrawingByID(drawingID);
    }

    public List<Drawing> GetAllDrawings(){
        return _dl.GetAllDrawings();
    }

    public List<Drawing> GetAllDrawingsByPlayerID(int playerID){
        return _dl.GetAllDrawingsByPlayerID(playerID);
    }
  
    public List<Drawing> GetAllDrawingsByWallPostID(int wallpostID){
        return _dl.GetAllDrawingsByWallPostID(wallpostID);
    }

    public void DeleteDrawingByID(int drawingID){
        _dl.DeleteDrawingByID(drawingID);
    }

    //Wall Posts
    public List<WallPost> GetAllWallPosts(){
        return _dl.GetAllWallPosts();
    }
    public void AddWallpost(WallPost wallpostToAdd){
        _dl.AddWallpost(wallpostToAdd);
    }

    public WallPost GetWallpostByID(int wallpostID){
        return _dl.GetWallpostByID(wallpostID);
    }

    public List<WallPost> GetAllWallpostByCategoryID(int CategoryID){
        return _dl.GetAllWallpostByCategoryID(CategoryID);
    }

    public WallPost GetWallpostByKeyword(string Key){
        return _dl.GetWallpostByKeyword(Key);
    }
    public void DeleteWallpostByID(int wallpostID){
        _dl .DeleteWallpostByID(wallpostID);
    }

    //Players
    public void AddNewPlayerAccount(Player playerToAdd){
        if(!_dl.IsDuplicate(playerToAdd))
        {
            _dl.AddNewPlayerAccount(playerToAdd);
        }
        else throw new DuplicateRecordException("A player with the same Username already exists");
    }

    public Player? GetPlayerByIDWithDrawings(int playerID){
        return _dl.GetPlayerByIDWithDrawings(playerID);
    }


    public void DeletePlayerByID(int playerID){
        _dl.DeletePlayerByID(playerID);
    }

    public List<Player> GetAllPlayersWithDrawings(){
        return _dl.GetAllPlayersWithDrawings();
    }

    public Player LoginPlayer(string username, string password){
        return _dl.LoginPlayer(username, password);
    }

    public bool IsDuplicate(Player player)
    {
        return _dl.IsDuplicate(player);
    }
}