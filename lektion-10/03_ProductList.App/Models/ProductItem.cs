using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ProductList.App.Models
{
    public class ProductItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; } = 0;
    }
}
