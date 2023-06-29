using ITI.Revision.MVC.Models;

namespace ITI.Revision.MVC.Services
{
    public interface ICategoryService
    {
        public List<Category> GetAllCategories();
        public Category GetCategoryById(int id);
        public void AddNewCategory(Category category);

    }
}
