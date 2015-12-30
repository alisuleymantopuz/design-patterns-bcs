using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.AdapterPattern
{
    public class CategoryRepository : ICategoryRepository
    {
        public IList<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category() { Id = 1, Name = "Beverages" });
            categories.Add(new Category() { Id = 2, Name = "Daily Products" });
            categories.Add(new Category() { Id = 3, Name = "Cold Drinks" });
            return categories;
        }
    }
}
