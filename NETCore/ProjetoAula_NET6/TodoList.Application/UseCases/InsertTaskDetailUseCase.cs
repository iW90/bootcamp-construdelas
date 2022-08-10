using AutoMapper;
using TodoList.Application.Models;
using TodoList.Core.Entities;
using TodoList.Core.Repositories;

namespace TodoList.Application.UseCases
{
    public class InsertTaskDetailUseCase : IUseCaseAsync<TaskRequest, TaskResponse>
    {
        private readonly IRepository _todoListRepository;
        private readonly IMapper _mapper;

        public InsertTaskDetailUseCase(IRepository todoListRepository, IMapper mapper)
        {
            _todoListRepository = todoListRepository;
            _mapper = mapper;
        }

        public Task<TaskResponse> ExecuteAsync(TaskRequest request)
        {
            var taskDetails = _mapper.Map<TaskDetail>(request);

            _todoListRepository.InserirTask(taskDetails);

            return Task.FromResult(new TaskResponse());
        }
    }
}
