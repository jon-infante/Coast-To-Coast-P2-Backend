using Model = Models;
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
}