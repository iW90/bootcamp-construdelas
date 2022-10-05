using DapperAPI.Services;
using FluentAssertions;
using System;
using Xunit;

namespace UnitTest.Services
{
    public class ValidationsTests
    {
        //private readonly IValidations _validations;

        public ValidationsTests()
        {
            //_validations = new Validations();
        }

        [Theory]
        [InlineData("Elizangela", 10)]
        [InlineData("Americana", 9)]
        public void ContarChar_RetornarQtd(string word, int result)
        {

            var _validations = new Validations();

            //Act
            var response = _validations.CountChacacter(word);

            //Assert
            Assert.Equal(result, response);
            Assert.InRange(response,0, 99);
            Assert.True(response > 0);

            response.Should().BeOfType(typeof(int));
        }
    }
}
