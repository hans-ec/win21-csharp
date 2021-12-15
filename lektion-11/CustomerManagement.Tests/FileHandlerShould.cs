using CustomerManagement.Handlers;
using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomerManagement.Tests
{
    public class FileHandlerShould
    {
        private IFileHandler _sut = new FileHandler();

        [Fact]
        public void Save_CustomerList_To_File()
        {
            // Arrange
            string filePath = @"d:\test\CustomerList.csv";
            var _customerList = new List<Customer>() { new Customer { Id = Guid.NewGuid(), Name = "Hans Mattin-Lassei", Email = "hans@domain.com" } };

            // Act
            bool succeeded = _sut.SaveToFile(_customerList, filePath);

            Assert.True(succeeded);
        
        }


        [Fact]
        public void Populate_CustomerList_From_File()
        {
            // Arrange
            string filePath = @"d:\test\CustomerList.csv";
            var _customerList = new List<Customer>() { new Customer { Id = Guid.NewGuid(), Name = "Hans Mattin-Lassei", Email = "hans@domain.com" } };
            _sut.SaveToFile(_customerList, filePath);
            
            // Act
            bool succeeded = _sut.ReadFromFile(filePath);

            // Assert
            Assert.True(succeeded);
        }
    }
}
