using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Application.Models.AdicionarUsuario;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.Application.UseCases
{
    public class AdicionarUsuarioUseCase : IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse>
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public AdicionarUsuarioUseCase(IUsuarioRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AdicionarUsuarioResponse> ExecuteAsync(AdicionarUsuarioRequest request)
        {
            var validator = new AdicionarUsuarioRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErros = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErros += error.ErrorMessage + " | ";

                throw new Exception(validatorErros);
            }

            if (request == null)
                return null;

            var usuario = _mapper.Map<Usuario>(request);

            await _repository.Inserir(usuario);

            return new AdicionarUsuarioResponse();
        }
    }
}
