using _04_MulipleDataPoints.App.Handlers;
using System.Collections.Generic;
using Xunit;

namespace _04_MultipleDataPoints.Tests.xUnit
{
    public class CalculatorHandlerShould
    {
        CalculatorHandler sut = new CalculatorHandler();

        [Fact]
        public void Add_One_Number()
        {
            // Action
            sut.Add(1);

            //Assert
            Assert.Equal(1, sut.Total);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 4, 5)]
        [InlineData(5, 5, 10)]
        public void Add_Two_Numbers(decimal value1, decimal value2, decimal expected)
        {
            // Action
            sut.Add(value1);
            sut.Add(value2);

            // Assert
            Assert.Equal(expected, sut.Total);
        }

        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(0.1, 0.1, 0.1, 0.3)]
        public void Add_Three_Numbers(decimal value1, decimal value2, decimal value3, decimal expected)
        {
            // Action
            sut.Add(value1);
            sut.Add(value2);
            sut.Add(value3);

            // Assert
            Assert.Equal(expected, sut.Total);
        }








        private static IEnumerable<object[]> testValues()
        {
            yield return new object[] { 10, new decimal[] { 5, 5 }};
            yield return new object[] { 10, new decimal[] { 2, 2, 3, 2, 1 } };
            yield return new object[] { 100, new decimal[] { 20, 20, 15, 25, 10, 5, 5 } };
        }

        [Theory]
        [MemberData(nameof(testValues))]
        public void Add_Multiple_Values(decimal expected, params decimal[] values)
        {
            // Action
            foreach (var value in values)
                sut.Add(value);

            // Assert
            Assert.Equal(expected, sut.Total);
        }
    }
}