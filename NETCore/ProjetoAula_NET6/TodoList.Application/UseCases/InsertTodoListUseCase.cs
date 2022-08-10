using AutoMapper;
using TodoList.Application.Models;
using TodoList.Core.Entities;
using TodoList.Core.Repositories;
//using TodoList.Infra.Repositories;

namespace TodoList.Application.UseCases
{
    public class InsertTodoListUseCase : IUseCaseAsync<TaskListRequest, TaskListResponse>
    {
        private readonly IRepository _todoListRepository;
        private readonly IMapper _mapper;

        public InsertTodoListUseCase(IRepository todoListRepository, IMapper mapper)
        {
            _todoListRepository = todoListRepository;
            _mapper = mapper;
        }

        public Task<TaskListResponse> ExecuteAsync(TaskListRequest request)
        {
            var taskList = _mapper.Map<TaskList>(request);

            _todoListRepository.Inserir(taskList);
            return Task.FromResult(new TaskListResponse());
        }
    }
}
