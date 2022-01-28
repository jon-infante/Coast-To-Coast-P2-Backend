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
    public List<Category> GetAllCategories()
    {
        return _context.Categories.Select(r => r).ToList();
    }
    public Category AddCategory(Category catToAdd)
    {
        _context.Add(catToAdd);
        _context.SaveChanges();

        return catToAdd;
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
}