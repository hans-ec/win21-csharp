using _04_MulipleDataPoints.App.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_MultipleDataPoint.Tests.MSTest
{
    [TestClass]
    public class CalculatorHandlerShould
    {
        CalculatorHandler sut = new CalculatorHandler();


        [TestMethod]
        public void Add_One_Number()
        {
            // Action
            sut.Add(1);

            //Assert
            Assert.AreEqual(1, sut.Total);
        }



        /*        
         
            I MSTest  har vi problem med decimal. När vi kör DataRow så klarar den bara av double. Men detta skapar problem
            om vi ska göra 0,1 + 0,1 + 0,1 som ska bli 0,3 men med double blir det 0.3000000000004


            DETTA FUNGERAR INTE!
            [DataTestMethod]
            [DataRow(1, 1, 2)]
            [DataRow(1, 4, 5)]
            [DataRow(5, 5, 10)]
            public void Add_Two_Numbers(decimal value1, decimal value2, decimal expected)
            {
                // Action
                sut.Add(value1);
                sut.Add(value2);

                // Assert
                Assert.AreEqual(expected, sut.Total);
            }


            DETTA FUNKAR MEN DET GER FEL VÄRDE ISTÄLLET
            [DataTestMethod]
            [DataRow(0.1, 0.1, 0.1, 0.3)]
            public void Add_Three_Numbers(double value1, double value2, double value3, double expected)
            {
                // Action
                sut.AddDouble(value1);
                sut.AddDouble(value2);
                sut.AddDouble(value3);

                // Assert
                Assert.AreEqual(expected, sut.TotalDouble);
            }




            DETTA FINNS INTE ALLS I MSTest och går endast att göra med xUNIT
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

         */

    }
}