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
}