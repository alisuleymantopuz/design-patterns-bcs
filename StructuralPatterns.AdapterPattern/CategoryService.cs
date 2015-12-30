using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.AdapterPattern
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICacheStorage _cacheStorage;

        public CategoryService(ICategoryRepository categoryRepository, ICacheStorage cacheStorage)
        {
            _categoryRepository = categoryRepository;
            _cacheStorage = cacheStorage;
        }

        public IList<Category> GetAllCategories()
        {
            IList<Category> categories;
            string storageKey = "GetAllCategories";
            categories = _cacheStorage.Retrieve<List<Category>>(storageKey);
            if (categories == null)
            {
                categories = _categoryRepository.GetCategories();
                _cacheStorage.Store(storageKey, categories);
            }

            return categories;
        }
    }
}
