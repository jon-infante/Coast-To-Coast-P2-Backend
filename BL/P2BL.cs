using Models;
using DL;

namespace BL;
public class P2BL : IBL
{
    private IRepo _dl;

    public P2BL(IRepo repo)
    {
        _dl = repo;
    }

    public List<Category> GetAllCategories()
    {
        return _dl.GetAllCategories();
    }

    public Category GetCategoryById(int ID)
    {
        return _dl.GetCategoryById(ID);
    }

    public void AddCategory(Category catToAdd)
    {
        _dl.AddCategory(catToAdd);
    }

    public void DeleteCategory(Category catToDelete)
    {
        _dl.DeleteCategory(catToDelete);
    }

    public List<Category> SearchCategories(string searchTerm)
    {
        return _dl.SearchCategories(searchTerm);
    }
}
