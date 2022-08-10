using TodoList.Application.Models;
using TodoList.Core.Entities;
using TodoList.Core.Repositories;

namespace TodoList.Application.UseCases
{
    public class InsertTodoListUseCase : IUseCaseAsync<TaskListRequest, TaskListResponse>
    {
        private readonly IRepository _todoListRepository;
        public InsertTodoListUseCase(IRepository todoListRepository)
        {
            _todoListRepository = todoListRepository;
        }

        public Task<TaskListResponse> ExecuteAsync(TaskListRequest request)
        {
            //TODO Mapeamento ser um AutoMapper
            var taskList = new TaskList
            {
                ListName = request.ListName
            };

            _todoListRepository.Inserir(taskList);
            return Task.FromResult(new TaskListResponse());
        }
    }
}
