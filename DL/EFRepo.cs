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
    public Category AddCategory(Category catToAdd)
    {
        _context.Add(catToAdd);
        _context.SaveChanges();

        return catToAdd;
    }
}