using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.DecoratorPattern2
{
    public class ProductService : IProductService
    {
        public IProductRepository ProductRepository { get; private set; }
        public ProductService()
        {
            this.ProductRepository = new ProductRepository();
        }
        public List<Product> GetProducts()
        {
            return ProductRepository.List().ToList();
        }
    }
}
