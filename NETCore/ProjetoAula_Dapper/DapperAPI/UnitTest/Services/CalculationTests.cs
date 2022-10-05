using DapperAPI.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest.Services
{
    public class CalculationTests
    {
        private readonly ICalculation _calculation;

        public CalculationTests()
        {
            _calculation = new Calculation();
        }

        [Theory]
        [InlineData(10, 10, 20)] // Soma de 10 + 10 = 20
        [InlineData(1, 9, 10)]   // Soma de 1 + 9 = 10
        [InlineData(99, 99, 198)]   // Soma de 99 + 99 = 198
        public void Calculate_ReturnSuccefull(int firstValue, int secondValue, int expectedResult)
        {
            // Arrange

            // Act
            var currentResult = _calculation.Calculate(firstValue, secondValue);

            // Assert
            currentResult.Should().BePositive();
            currentResult.Should().BeGreaterThan(0);
            currentResult.Should().BeOfType(typeof(int));
            firstValue.Should().BeInRange(0, 99);
            secondValue.Should().BeInRange(0, 99);
            currentResult.Should().BeInRange(0, 198);

            Assert.Equal(expectedResult, currentResult);
        }

        [Theory]
        [InlineData(100, 10)]
        [InlineData(10, 200)]
        public void Calculate_ReturnException(int firstValue, int secondValue)
        {
            // Arrange
            var exceptionMessage = "Um ou mais valores maior que 99";

            // Act
            try
            {
                var exception = _calculation.Calculate(firstValue, secondValue);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Contains(exceptionMessage, ex.Message);
                ex.Should().BeOfType(typeof(ArgumentException));
            }
        }
    }
}
