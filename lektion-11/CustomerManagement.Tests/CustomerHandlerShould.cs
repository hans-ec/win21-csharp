using CustomerManagement.Handlers;
using CustomerManagement.Models;
using System;
using Xunit;

namespace CustomerManagement.Tests
{
    public class CustomerHandlerShould
    {
        private ICustomerHandler _sut = new CustomerHandler();


        [Fact]
        public void Add_Customer_To_CustomerList()
        {
            // Arrange
            Customer _customer = new Customer() { Id = Guid.NewGuid(), Name = "Hans Mattin-Lassei", Email = "hans@domain.com" };

            // Act
            bool succeeded = _sut.AddToList(_customer);

            // Assert
            Assert.True(succeeded);
        }


        [Fact]
        public void Get_Customer_From_CustomerList()
        {
            // Arrange
            Customer _customer = new Customer() { Id = Guid.NewGuid(), Name = "Hans Mattin-Lassei", Email = "hans@domain.com" };
            _sut.AddToList(_customer);

            // Act
            Customer _returnedCustomer = _sut.GetCustomerFromList(_customer.Id);

            // Assert
            Assert.IsType<Customer>(_returnedCustomer);
        }



        [Fact]
        public void Remove_Customer_From_CustomerList()
        {
            // Arrange
            var _customer = new Customer() { Id = Guid.NewGuid(), Name = "Hans Mattin-Lassei", Email = "hans@domain.com" };
            _sut.AddToList(_customer);

            // Act
            bool succeeded = _sut.RemoveFromList(_customer.Id);

            // Assert
            Assert.True(succeeded);
        }
    }
}