using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.DecoratorPattern2
{
    public class ProductServiceDecorator : IProductService
    {
        public IProductRepository ProductRepository { get; private set; }
        public IProductService ProductService { get; private set; }

        public ProductServiceDecorator(IProductService productService)
        {
            this.ProductRepository = new ProductRepository();
            this.ProductService = productService;
        }

        public virtual List<Product> GetProducts()
        {
            return this.ProductService.GetProducts();
        }
    }
}
