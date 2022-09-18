using System.Threading.Tasks;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Core.Interfaces;

namespace WoMakersCode.ToDoList.Application.UseCases
{
    public class GetTodoListUseCase : IUseCaseAsync<int, TaskListResponse>
    {
        private readonly IRepository _todoListRepository;
        public GetTodoListUseCase(IRepository todoListRepository)
        {
            _todoListRepository = todoListRepository;
        }

        public Task<TaskListResponse> ExecuteAsync(int request)
        {
            var resposta = _todoListRepository.GetTaskList(request).Result;

            var response = (TaskListResponse)null;

            if (resposta != null)
            {
                response = new TaskListResponse()
                {
                    Id = resposta.Id,
                    ListName = resposta.ListName
                };
            }

            return Task.FromResult(response);
        }
    }
}
