using _03_ProductList.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ProductList.App.Handlers
{
    public class ProductHandler
    {
        public List<ProductItem> ProductItems { get; private set; } = new List<ProductItem>();

        public ProductItem Create(string productName, string description, decimal price)
        {
            return new ProductItem { Name = productName, Description = description, Price = price };
        }

        public void AddToList(ProductItem productItem)
        {
            ProductItems.Add(productItem);
        }

        public IEnumerable<ProductItem> GetAll()
        {
            return ProductItems;
        }

        public ProductItem Get(Guid id)
        {
            return ProductItems.Find(x => x.Id == id);
        }
    }
}
