using Models;
using DL;

namespace BL;
public class P2BL : IBL
{
    private IRepo _dl;
    public P2BL(IRepo repo) {
        _dl = repo;
    }

    public void AddCategory(Category catToAdd)
    {
        throw new NotImplementedException();
    }

    public void AddDrawing(Drawing drawingToAdd)
    {
        throw new NotImplementedException();
    }

    public void AddWallpost(WallPost wallpostToAdd)
    {
        throw new NotImplementedException();
    }

    public void DeleteCategory(Category catToDelete)
    {
        throw new NotImplementedException();
    }

    public void DeleteDrawingByID(int DrawingID)
    {
        throw new NotImplementedException();
    }

    public void DeleteWallpostByID(int WallpostID)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public List<Drawing> GetAllDrawingsByUserID(int UserID)
    {
        throw new NotImplementedException();
    }

    public List<Drawing> GetAllDrawingsByWallPostID(int WallPostID)
    {
        throw new NotImplementedException();
    }


    public List<WallPost> GetAllWallpostByCategoryID(int CategoryID)
    {
        throw new NotImplementedException();
    }

    public Category GetCategoryById(int ID)
    {
        throw new NotImplementedException();

    }

    public WallPost GetWallpostByID(int WallpostID)
    {
        throw new NotImplementedException();
    }

    public WallPost GetWallpostByKeyword(string Key)
    {
        throw new NotImplementedException();
    }

    public List<Category> SearchCategories(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Drawing GetDrawingByID(int DrawingID)
    {
        throw new NotImplementedException();
    }
    public Player AddNewPlayerAccount(Player playerToAdd)
    {
        return _dl.AddNewPlayerAccount(playerToAdd);
    }
    public Player GetPlayerByID(int PlayerID)
    {
        return _dl.GetPlayerByID(PlayerID);
    }

    public async Task<Player?> GetPlayerByIDWithDrawingsAsync(int PlayerID)
    {
        return await _dl.GetPlayerByIDWithDrawingsAsync(PlayerID);
    }

    public void DeletePlayerByID(int PlayerID)
    {
        _dl.DeletePlayerByID(PlayerID);
    }

    public List<Player> GetAllPlayers()
    {
        return _dl.GetAllPlayers();
    }

    public async Task<List<Player>> GetAllPlayersWithDrawingsAsync()
    {
        return await _dl.GetAllPlayersWithDrawingsAsync();
    }


}
