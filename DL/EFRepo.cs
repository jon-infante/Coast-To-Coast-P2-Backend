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

    
}