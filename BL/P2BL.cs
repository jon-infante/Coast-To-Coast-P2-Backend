using Models;
using DL;

namespace BL;
public class P2BL : IBL
{
    private IRepo _dl;
    public P2BL(IRepo repo) {
        _dl = repo;
    }

    public Player AddNewPlayerAccount(Player playerToAdd)
    {
        return _dl.AddNewPlayerAccount(playerToAdd);
    }
}