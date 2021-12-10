using _03_ProductList.App.Handlers;
using _03_ProductList.App.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace _03_ProductList.Tests.nUnit
{
    public class ProductHandlerShould
    {
        private ProductHandler sut;

        [SetUp]
        public void Setup()
        {
            sut = new ProductHandler();
        }

        [Test]
        public void Create_New_Product()
        {
            // Action
            ProductItem item = sut.Create("Product Name goes here", "Product Description goes here", 100m);

            // Assert
            Assert.NotNull(item);
        }


        [Test]
        public void Add_Product_To_List()
        {
            // Action
            sut.AddToList(sut.Create("Product Name goes here", "Product Description goes here", 100m));

            // Assert
            Assert.True(sut.ProductItems.Any());
        }

        [Test]
        public void List_All_Products()
        {
            // Arrange
            int expected = 10;
            for (int i = 0; i < expected; i++)
                sut.AddToList(sut.Create($"Product Name {i + 1} goes here", "Product Description goes here", 100m));

            // Action
            IEnumerable<ProductItem> products = sut.GetAll();

            // Assert
            Assert.AreEqual(expected, products.Count());
        }

        [Test]
        public void List_Specific_Product()
        {
            // Arrange
            ProductItem product = sut.Create("Product Name goes here", "Product Description goes here", 100m);
            sut.AddToList(product);

            // Action
            ProductItem _product = sut.Get(product.Id);

            // Assert
            Assert.AreEqual(product, _product);
        }
    }
}