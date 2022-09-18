using AutoMapper;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Core.Entities;
using WoMakersCode.ToDoList.Core.Interfaces;

namespace WoMakersCode.ToDoList.Application.UseCases
{
    public class InsertTodoListUseCase : IUseCaseAsync<TaskListRequest, InsertToDoListResponse>
    {
        private readonly ITaskListRepository _repository;
        private readonly IMapper _mapper;

        public InsertTodoListUseCase(ITaskListRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<InsertToDoListResponse> ExecuteAsync(TaskListRequest request)
        {
            var resp = await _repository.GetById(new Core.Filters.GetFilter { Pesquisa = request.ListName });

            if (resp == null)
            {
                var taskList = _mapper.Map<TaskList>(request);
                await _repository.Insert(taskList);
                return new InsertToDoListResponse();
            }
            else
                return null;
        }
    }
}
