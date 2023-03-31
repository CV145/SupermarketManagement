using CoreBusiness;
using UseCases;
using UseCases.UseCaseInterfaces;

namespace Plugins.DataStore.InMemory
{
    //To be swapped with SQL later
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category {ID=1, Name="Beverage", Description="Beverage"},
                 new Category {ID=2, Name="Bakery", Description="Bakery"},
                  new Category {ID=3, Name="Meat", Description="Meat"},
            };
        }

		public void AddCategory(Category category)
		{
            if (_categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = _categories.Max(x => x.ID);
            category.ID = maxId + 1;

            _categories.Add(category);
		}

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = _categories?.FirstOrDefault(x => x.ID == category.ID);
            if (categoryToUpdate != null) categoryToUpdate = category;
        }

		public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

		public Category GetCategoryById(int id)
		{
            return _categories.Find(x => x.ID == id);
		}

		public void DeleteCategory(int id)
		{
			var categoryToDelete = _categories?.FirstOrDefault(x => x.ID == id);
            if (categoryToDelete != null) { _categories?.Remove(categoryToDelete); }
		}
	}
}