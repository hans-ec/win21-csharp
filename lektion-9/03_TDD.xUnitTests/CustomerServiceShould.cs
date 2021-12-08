using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _03_TDD.xUnitTests
{
    public class CustomerServiceShould
    {
        [Fact]
        public async Task Get_All_Customers()
        {
            // prep
            var sut = new CustomerService();

            // act
            var customers = await sut.GetCustomersAsync();

            //assert
            Assert.True(customers.Any());

        }
    }
}
