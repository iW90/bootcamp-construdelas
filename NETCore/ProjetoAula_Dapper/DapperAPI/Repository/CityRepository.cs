using Dapper;
using DapperAPI.Context;
using DapperAPI.Contracts;
using DapperAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAPI.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DapperContext _context;

        public CityRepository(DapperContext context) => _context = context;

        public async Task<IEnumerable<City>> GetCities()
        {
            var query = "Select Id, Name From Cities";

            using (var connection = _context.CreateConnection())
            {
                var cities = await connection.QueryAsync<City>(query);
                return cities.ToList();
            }
        }

        public async Task<City> GetCity(int id)
        {
            var query = "Select Id, Name From Cities Where Id = @id";

            using (var connection = _context.CreateConnection())
            {
                var city = await connection.QuerySingleAsync<City>(query, new { id });
                return city;
            }
        }
    }
}
