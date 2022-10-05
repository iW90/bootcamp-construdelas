using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaLutzStore.Core.Interfaces
{
    public interface IRepository<T>
    {
        Task New(T obj);
        Task Update(T obj);
        Task Delete(T obj);
        Task<T> Search(int id);
        Task<T> SearchAux(int id);
        Task<IEnumerable<T>> SearchAll();
    }
}
