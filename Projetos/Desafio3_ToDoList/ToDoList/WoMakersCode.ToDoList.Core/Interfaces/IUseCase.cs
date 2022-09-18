using System.Threading.Tasks;

namespace WoMakersCode.ToDoList.Core.Interfaces
{
    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
