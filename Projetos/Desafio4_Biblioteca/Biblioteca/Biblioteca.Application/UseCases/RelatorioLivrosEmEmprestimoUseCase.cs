using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.Models.LivrosEmEmprestimo;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.Application.UseCases
{
    public class RelatorioLivrosEmEmprestimoUseCase : IUseCaseAsync<LivrosEmEmprestimoRequest, List<LivrosEmEmprestimoResponse>>
    {
        public readonly IRelatorioRepository _repository;
        public readonly IMapper _mapper;

        public RelatorioLivrosEmEmprestimoUseCase(IRelatorioRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<LivrosEmEmprestimoResponse>> ExecuteAsync(LivrosEmEmprestimoRequest request)
        {
            var atrasos = await _repository.RelatorioLivrosEmprestados();
            var atrasosResponse = _mapper.Map<List<LivrosEmEmprestimoResponse>>(atrasos);

            return atrasosResponse;
        }
    }
}
