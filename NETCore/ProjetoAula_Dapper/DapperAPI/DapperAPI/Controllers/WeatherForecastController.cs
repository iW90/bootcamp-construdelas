    using DapperAPI.Contracts;
using DapperAPI.DTO;
using DapperAPI.Entities;
using DapperAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMemoryCache _cache;
        private readonly IValidations _validations;

        private const string KEY_CITY = "Cidades";
        
        public WeatherForecastController(
            ICityRepository cityRepository, 
            IMemoryCache cache, 
            IValidations validations)
        {
            _cityRepository = cityRepository;
            _cache = cache;
            _validations = validations;
        }

        /// <summary>
        /// Meu primeiro método no swagger
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public async Task<ActionResult> GetCities()
        {
            if (_cache.TryGetValue(KEY_CITY, out List<City> cacheCities))
            {
                return Ok(cacheCities);
            }

            var cities = await _cityRepository.GetCities();

            //Definir o tempo de armazenamento do cache
            var memoryCacheOptions = new MemoryCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(3), //Expira depois de 3 min
                SlidingExpiration = TimeSpan.FromMinutes(1) // Expira em 1 minuto se não for acessado
            };

            _cache.Set(KEY_CITY, cities, memoryCacheOptions);

            return Ok(cities);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            if (id > 100)
            {
                throw new ArgumentException("O Id não pode ser maior que 100");
            }

            var cities = await _cityRepository.GetCity(id);
            return Ok(cities);
        }

        /// <summary>
        /// Criar novo Endereço
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "Id": 1,
        ///        "CityId": "1",
        ///        "Adress": "Rua X",
        ///        "Number": "123",
        ///        "Active": true
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Retorna quando o registro for inserido</response>
        /// <response code="400">Retorna quando acontece algum erro</response>
        [HttpPost("AddAdress")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<ActionResult> PostAdress(AdressDTO dto)
        {
            return null;
        }
    }
}
