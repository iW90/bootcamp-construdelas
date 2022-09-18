using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Application.Models.AdicionarAutor;
using Biblioteca.Application.UseCases;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutorController : ControllerBase
    {
        private readonly IUseCaseAsync<AdicionarAutorRequest, AdicionarAutorResponse> _useCaseAsync;

        public AutorController(IUseCaseAsync<AdicionarAutorRequest, AdicionarAutorResponse> useCaseAsync)
        {
            _useCaseAsync = useCaseAsync;
        }

        //Inserir()
        [HttpPost]
        public async Task<ActionResult<AdicionarAutorResponse>> Post([FromBody] AdicionarAutorRequest request)
        {
            return await _useCaseAsync.ExecuteAsync(request);
        }
    }
}
