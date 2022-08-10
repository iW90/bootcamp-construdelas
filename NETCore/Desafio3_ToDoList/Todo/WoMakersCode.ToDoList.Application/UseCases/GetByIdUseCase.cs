using AutoMapper;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Core.Filters;
using WoMakersCode.ToDoList.Core.Repositories;

namespace WoMakersCode.ToDoList.Application.UseCases
{
    public class GetByIdUseCase : IUseCaseAsync<GetFilter, GetByIdResponse>
    {
        public readonly ITaskListRepository _repository;
        public readonly IMapper _mapper;

        public GetByIdUseCase(ITaskListRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public  Task<GetByIdResponse> ExecuteAsync(GetFilter filter)
        {
            var resposta = _repository.GetById(filter).Result;

            var response = (GetByIdResponse)null;

            if (resposta != null)
            {
                response = _mapper.Map<GetByIdResponse>(resposta);
            }

            return Task.FromResult(response);
        }
    }
}
