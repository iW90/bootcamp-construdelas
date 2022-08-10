using System.Threading.Tasks;

namespace WoMakersCode.ToDoList.Application.UseCases
{
    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
