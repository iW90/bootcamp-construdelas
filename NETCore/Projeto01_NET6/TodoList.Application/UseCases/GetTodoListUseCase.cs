using TodoList.Application.Models;
using TodoList.Core.Repositories;

namespace TodoList.Application.UseCases
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
