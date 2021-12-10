using _03_ProductList.App.Handlers;
using _03_ProductList.App.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace _03_ProductList.Tests.xUnit
{
    public class ProductHandlerShould
    {
        ProductHandler sut = new ProductHandler();

        [Fact]
        public void Create_New_Product()
        {
            // Assert
            Assert.NotNull(sut.Create("Product Name goes here", "Product Description goes here", 100m));
        }

        [Fact]
        public void Add_Product_To_List()
        {
            // Action
            sut.AddToList(sut.Create("Product Name goes here", "Product Description goes here", 100m));

            // Assert
            Assert.True(sut.ProductItems.Any());
        }

        [Fact]
        public void List_All_Products()
        {
            // Arrange
            int expected = 10;
            for(int i = 0; i < expected; i++)
                sut.AddToList(sut.Create($"Product Name {i+1} goes here", "Product Description goes here", 100m));

            // Action
            IEnumerable<ProductItem> products = sut.GetAll();

            // Assert
            Assert.Equal(expected, products.Count());
        }

        [Fact]
        public void List_Specific_Product()
        {
            // Arrange
            ProductItem product = sut.Create("Product Name goes here", "Product Description goes here", 100m);
            sut.AddToList(product);

            // Action
            ProductItem _product = sut.Get(product.Id);

            // Assert
            Assert.Equal(product, _product);
        }
    }
}