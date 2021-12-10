using _03_ProductList.App.Handlers;
using _03_ProductList.App.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace _03_ProductList.Tests.MSTest
{
    [TestClass]
    public class ProductHandlerShould
    {
        ProductHandler sut = new ProductHandler();

        [TestMethod]
        public void Create_New_Product()
        {
            // Assert
            Assert.IsNotNull(sut.Create("Product Name goes here", "Product Description goes here", 100m));
        }

        [TestMethod]
        public void Add_Product_To_List()
        {
            // Action
            sut.AddToList(sut.Create("Product Name goes here", "Product Description goes here", 100m));

            // Assert
            Assert.IsTrue(sut.ProductItems.Any());
        }

        [TestMethod]
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

        [TestMethod]
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