using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.Models.LivrosDisponiveis;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.Application.UseCases
{
    public class RelatorioLivrosDisponiveisUseCase : IUseCaseAsync<LivrosDisponiveisRequest, List<LivrosDisponiveisResponse>>
    {
        public readonly IRelatorioRepository _repository;
        public readonly IMapper _mapper;

        public RelatorioLivrosDisponiveisUseCase(IRelatorioRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<LivrosDisponiveisResponse>> ExecuteAsync(LivrosDisponiveisRequest request)
        {
            var atrasos = await _repository.RelatorioLivrosDisponiveis();
            var atrasosResponse = _mapper.Map<List<LivrosDisponiveisResponse>>(atrasos);

            return atrasosResponse;
        }
    }
}
