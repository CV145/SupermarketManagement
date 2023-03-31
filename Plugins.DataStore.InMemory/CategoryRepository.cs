using CoreBusiness;
using UseCases;

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
		}

		public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }
    }
}