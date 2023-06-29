using ITI.Revision.MVC.Data;
using ITI.Revision.MVC.Models;

namespace ITI.Revision.MVC.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories = ITIRevisionMVCContext.Categories.ToList();
            return categories;
        }

        public Category GetCategoryById(int id) 
        {
                Category? category = ITIRevisionMVCContext.Categories.FirstOrDefault(c => c.Id == id);
                 return category;
        }

        public void AddNewCategory(Category category)
        {
            ITIRevisionMVCContext.Categories.Add(category);
        }

    }
}
