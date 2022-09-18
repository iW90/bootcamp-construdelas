using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Interfaces
{
    public interface IEmprestimoRepository : IRepository<Emprestimo>
    {
        Task<Emprestimo> ListarPorIdParaAtualizarEmprestimo(int id);
        Task<List<Emprestimo>> ListarEmprestimosEmAtraso(int diasParaDevolucao);
    }
}
