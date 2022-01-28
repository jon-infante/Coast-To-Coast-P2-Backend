using Models;
namespace BL;

public interface IBL
{   
    List<Category> GetAllCategories();
    Category GetCategoryById(int ID);
    void AddCategory(Category catToAdd);
    void DeleteCategory(Category catToDelete);
    List<Category> SearchCategories(string searchTerm);

}
