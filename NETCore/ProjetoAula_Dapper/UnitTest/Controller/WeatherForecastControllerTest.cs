using DapperAPI.Contracts;
using DapperAPI.Controllers;
using DapperAPI.Entities;
using DapperAPI.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest.Controller
{
    public class WeatherForecastControllerTest
    {
        private readonly WeatherForecastController _controller;
        private readonly Mock<ICityRepository> _cityRepositoryMock;
        private readonly Mock<IValidations> _validationsMock;
        private readonly IMemoryCache _memoryCache;

        public WeatherForecastControllerTest()
        {
            _cityRepositoryMock = new Mock<ICityRepository>();
            _validationsMock = new Mock<IValidations>();

            _memoryCache = new MemoryCache(new MemoryCacheOptions());

            _controller = new WeatherForecastController(
                _cityRepositoryMock.Object,
                _memoryCache,
                _validationsMock.Object);
        }

        [Fact]
        public async Task ObterClima_PorCidade_SucessoAsync()
        {
            #region Arrange
            var cityId = 1;

            var cityResponse = new City
            {
                Id = cityId,
                Name = "Americana"
            };

            _cityRepositoryMock.Setup(s => s.GetCity(cityId)) //Como mockar o retorno do repositório
                .ReturnsAsync(cityResponse);
            #endregion

            //Act
            var response = await _controller.GetById(cityId);

            #region Assert
            var statusCode = ((ObjectResult)response).StatusCode; // Converte o objeto em ObjectResult
            Assert.Equal(200, statusCode);                  // Valido se o StatusCode é 200

            var value = ((ObjectResult)response).Value;     // Converte o objeto em ObjectResult
            value.Should().NotBeNull();                     // Valido se retornou algo
            value.Should().BeOfType<City>();                // Valido o tipo do objeto
            ((City)value).Name.Should().Be("Americana");    // Valido o campo name
            ((City)value).Id.Should().Be(cityId);           // Valido o campo id

            //Verify - FluentAssertions - Mock
            _cityRepositoryMock.Verify(v => v.GetCity(cityId), Times.Once());
            #endregion
        }


        [Fact]
        public async Task ObterClima_TodasCidades_Sucesso()
        {
            // Arrange
            var cities = new List<City>();
            cities.Add(new City { Id = 1, Name = "Americana" });
            cities.Add(new City { Id = 2, Name = "Campinas" });

            _cityRepositoryMock.Setup(s => s.GetCities())
                .ReturnsAsync(cities);

            // Act
            var response = await _controller.GetCities();

            // Assert
            var statusCode = ((ObjectResult)response).StatusCode;
            Assert.Equal(200, statusCode);

            var value = ((ObjectResult)response).Value;
            value.Should().NotBeNull();
            value.Should().BeOfType<List<City>>();
        }

        [Fact]
        public async Task ObetClime_PorId_RetornaException()
        {
            // Arrange
            var cityId = 101;
            var expectedMessage = "O Id não pode ser maior que 100";

            // Act
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _controller.GetById(cityId));
            Assert.Equal(expectedMessage, ex.Result.Message);
        }
    }
}
