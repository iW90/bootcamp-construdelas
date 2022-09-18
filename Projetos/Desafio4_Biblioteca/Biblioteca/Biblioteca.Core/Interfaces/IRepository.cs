using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteca.Core.Interfaces
{
    public interface IRepository<T>
    {
        Task Inserir(T obj);
        Task Atualizar(T obj);
        Task<IEnumerable<T>> ListarTodos();
        Task<T> BuscarPorId(int id);
        Task Excluir(T obj);
    }
}