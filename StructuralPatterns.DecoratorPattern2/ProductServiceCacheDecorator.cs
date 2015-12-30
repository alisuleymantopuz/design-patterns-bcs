using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.DecoratorPattern2
{
    public class ProductServiceCacheDecorator  : ProductServiceDecorator
    {
        public ProductServiceCacheDecorator(IProductService productService)
            :base(productService)
        {
            
        }

        public override List<Product> GetProducts()
        {
            ObjectCache cache = MemoryCache.Default;
            string key = "products";
            if (cache.Contains(key))
            {
                return (List<Product>)cache[key];
            }
            else
            {
                List<Product> products = base.ProductService.GetProducts();
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddMinutes(1));
                cache.Add(key, products, policy);
                return products;
            }
        }
    }
}
