using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.Models.ExcluirEmprestimo;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.Application.UseCases
{
    public class ExcluirEmprestimoUseCase : IUseCaseAsync<ExcluirEmprestimoRequest, ExcluirEmprestimoResponse>
    {
        private readonly IEmprestimoRepository _repository;

        public ExcluirEmprestimoUseCase(IEmprestimoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExcluirEmprestimoResponse> ExecuteAsync(ExcluirEmprestimoRequest request)
        {
            var emprestimo = await _repository.ListarPorId(request.Id);

            await _repository.Excluir(emprestimo);

            return new ExcluirEmprestimoResponse();
        }
    }
}
