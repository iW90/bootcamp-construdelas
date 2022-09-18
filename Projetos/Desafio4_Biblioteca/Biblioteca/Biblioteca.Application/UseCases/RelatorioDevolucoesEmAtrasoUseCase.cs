using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.Models.DevolucoesEmAtraso;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.Application.UseCases
{
    public class RelatorioDevolucoesEmAtrasoUseCase : IUseCaseAsync<DevolucoesEmAtrasoFiltroRequest, List<DevolucoesEmAtrasoResponse>>
    {
        public readonly IRelatorioRepository _repository;
        public readonly IMapper _mapper;

        public RelatorioDevolucoesEmAtrasoUseCase(IRelatorioRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<DevolucoesEmAtrasoResponse>> ExecuteAsync(DevolucoesEmAtrasoFiltroRequest request)
        {
            var atrasos = await _repository.RelatorioLivrosEmAtraso(request.DataEmprestimo, request.DataDevolucao, request.NomeUsuario, request.TituloLivro);
            var atrasosResponse = _mapper.Map<List<DevolucoesEmAtrasoResponse>>(atrasos);

            return atrasosResponse;
        }
    }
}
