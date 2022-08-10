using AutoMapper;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Core.Entities;
using WoMakersCode.ToDoList.Core.Repositories;

namespace WoMakersCode.ToDoList.Application.UseCases
{
    public class InsertTaskDetailUseCase : IUseCaseAsync<TaskRequest, TaskResponse>
    {
        private readonly ITaskDetailRepository _todoListRepository;
        private readonly IMapper _mapper;

        public InsertTaskDetailUseCase(ITaskDetailRepository todoListRepository, IMapper mapper)
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
