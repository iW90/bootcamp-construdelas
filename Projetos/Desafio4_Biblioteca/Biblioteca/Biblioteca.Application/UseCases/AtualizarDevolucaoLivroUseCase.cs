using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.Models.AtualizarDevolucaoLivro;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.Application.UseCases
{
    public class AtualizarDevolucaoLivroUseCase : IUseCaseAsync<AtualizarDevolucaoLivroRequest, AtualizarDevolucaoLivroResponse>
    {
        private readonly IEmprestimoRepository _repository;

        public AtualizarDevolucaoLivroUseCase(IEmprestimoRepository repository)
        {
            _repository = repository;
        }

        public async Task<AtualizarDevolucaoLivroResponse> ExecuteAsync(AtualizarDevolucaoLivroRequest request)
        {
            var emprestimo = await _repository.ListarPorIdParaAtualizarEmprestimo(request.Id);

            emprestimo.DataDevolucao = DateTime.Now;

            await _repository.Atualizar(emprestimo);

            return new AtualizarDevolucaoLivroResponse();
        }
    }
}
