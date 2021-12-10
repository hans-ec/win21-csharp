using _01_ConsoleApp.Models;
using Xunit;

namespace _01_ConsoleApp.Tests
{
    public class CalculatorShould
    {
        [Fact]
        public void Add_Value_To_Total()
        {
            /* Arrange */
            Calculator sut = new Calculator();

            /* Act */
            sut.Add(21);

            /* Assert */
            Assert.Equal(21, sut.Total);
        }
    }
}