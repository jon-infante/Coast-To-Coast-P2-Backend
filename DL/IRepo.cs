namespace DL;

public interface IRepo
{
    List<Category> GetAllCategories();
    Category GetCategoryById(int ID);
    void AddCategory(Category catToAdd);
    void DeleteCategory(Category catToDelete);
    List<Category> SearchCategories(string searchTerm);
}