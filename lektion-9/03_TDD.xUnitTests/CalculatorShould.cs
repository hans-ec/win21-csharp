using Xunit;

namespace _03_TDD.xUnitTests
{
    /*   SUT = System Under Test   */

    public class CalculatorShould
    {

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 2, 3)]
        [InlineData(10, 8, 2)]
        [InlineData(0.2, 0.1, 0.1)]
        public void Add_Two_Number_Together_And_Return_Value(decimal expected, decimal v1, decimal v2)
        {
            // prep
            var sut = new Calculator();

            // act
            var sum = sut.Add(v1, v2);

            //assert
            Assert.Equal(expected, sum);

        }

        [Fact]
        public void Subtract_Two_Number_And_Return_Value()
        {
            // prep
            var sut = new Calculator();

            // act
            var sum = sut.Sub(10, 5);

            //assert
            Assert.Equal(5, sum);

        }

        [Fact]
        public void Muliply_Two_Number_And_Return_Value()
        {
            // prep
            var sut = new Calculator();

            // act
            var sum = sut.Mul(10.5, 2);

            //assert
            Assert.Equal(21, sum);

        }

    }
}