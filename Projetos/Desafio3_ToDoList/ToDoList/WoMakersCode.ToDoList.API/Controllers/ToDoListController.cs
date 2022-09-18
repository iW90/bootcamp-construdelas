using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Application.UseCases;
using WoMakersCode.ToDoList.Core.Filters;
using WoMakersCode.ToDoList.Core.Interfaces;

namespace WoMakersCode.ToDoList.Controllers
{
    [ApiController]
    [Route("api/todolist")]
    public class ToDoListController : ControllerBase
    {
        private readonly IUseCaseAsync<TaskListRequest, List<TaskListResponse>> _getAllUseCase;
        private readonly IUseCaseAsync<GetFilter, GetByIdResponse> _getByIdUseCase;
        private readonly IUseCaseAsync<TaskListRequest, InsertToDoListResponse> _insertTodoListUseCase;
        private readonly IUseCaseAsync<List<InsertAlarmRequest>, InsertAlarmResponse> _insertAlarmUseCase;
        private readonly IUseCaseAsync<TaskRequest, TaskResponse> _insertTaskDetailUseCase;

        public ToDoListController(
            IUseCaseAsync<TaskListRequest, List<TaskListResponse>> getAllUseCase,
            IUseCaseAsync<GetFilter, GetByIdResponse> getByIdUseCase,
            IUseCaseAsync<TaskListRequest, InsertToDoListResponse> insertTodoListUseCase,
            IUseCaseAsync<List<InsertAlarmRequest>, InsertAlarmResponse> insertAlarmUseCase,
            IUseCaseAsync<TaskRequest, TaskResponse> insertTaskDetailUseCase)
        {
            _getAllUseCase = getAllUseCase;
            _getByIdUseCase = getByIdUseCase;
            _insertTodoListUseCase = insertTodoListUseCase;
            _insertAlarmUseCase = insertAlarmUseCase;
            _insertTaskDetailUseCase = insertTaskDetailUseCase;
        }

        [HttpGet("All")]
        public async Task<ActionResult<List<TaskListResponse>>> Get([FromQuery] TaskListRequest request)
        {
            return await _getAllUseCase.ExecuteAsync(request);
        }

        [HttpGet("id")]
        public async Task<ActionResult<GetByIdResponse>> Get([FromQuery] GetFilter filter)
        {
            var response = await _getByIdUseCase.ExecuteAsync(filter);
            if (response == null)
                return new NotFoundObjectResult("Não encontrado");

            return new OkObjectResult(response);
        }

        [HttpPost]
        public async Task<ActionResult<InsertToDoListResponse>> Post([FromBody] TaskListRequest request)
        {
            var resposta = await _insertTodoListUseCase.ExecuteAsync(request);

            if (resposta != null)
                return Ok(resposta);
            else
                return new BadRequestObjectResult("Lista já existente");
        }

        [HttpPost("insertAlarm")]
        public async Task<ActionResult<InsertAlarmResponse>> PostMultiplus([FromBody] List<InsertAlarmRequest> request)
        {
            var resposta = await _insertAlarmUseCase.ExecuteAsync(request);
            return Ok(resposta);
        }


        [HttpPost("task")]
        public async Task<ActionResult<TaskResponse>> PostTask([FromBody] TaskRequest request)
        {
            var resposta = await _insertTaskDetailUseCase.ExecuteAsync(request);
            return Ok(resposta);

        }
    }
}
