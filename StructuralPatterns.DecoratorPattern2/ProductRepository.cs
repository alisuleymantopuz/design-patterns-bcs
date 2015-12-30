using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.DecoratorPattern2
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> List()
        {
            return new List<Product>()
                  {
                      new Product(){Id = 1, Name = "Mouse", StockQuantity = 2},
                      new Product(){Id = 2, Name = "Keyboard", StockQuantity = 11},
                      new Product(){Id = 3, Name = "Monitor", StockQuantity = 15},
                  };
        }
    }
}
