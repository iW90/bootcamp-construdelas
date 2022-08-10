using Microsoft.AspNetCore.Mvc;
using TodoList.Application.Models;
using TodoList.Application.UseCases;
using TodoList.Core.DTOs;

namespace TodoList.API.Controllers
{
    [ApiController]
    [Route("api/todolist")]
    public class TodoListController : ControllerBase
    {

        private readonly ILogger<TodoListController> _logger;
        private readonly IUseCaseAsync<TaskListRequest, TaskListResponse> _insertUseCase;
        private readonly IUseCaseAsync<int, TaskListResponse> _getUseCase;
        private readonly IUseCaseAsync<TaskRequest, TaskResponse> _insertTaskDetailUseCase;
        private readonly IUseCaseAsync<string, WeatherDTO> _getWeatherForecastUseCase;

        public TodoListController(ILogger<TodoListController> logger,
            IUseCaseAsync<TaskListRequest, TaskListResponse> insertUseCase,
            IUseCaseAsync<int, TaskListResponse> getUseCase,
            IUseCaseAsync<TaskRequest, TaskResponse> insertTaskDetailUseCase,
            IUseCaseAsync<string, WeatherDTO> getWeatherForecastUseCase)
        {
            _logger = logger;
            _insertUseCase = insertUseCase;
            _getUseCase = getUseCase;
            _insertTaskDetailUseCase = insertTaskDetailUseCase;
            _getWeatherForecastUseCase = getWeatherForecastUseCase;
        }

        [HttpGet("id")]
        public async Task<ActionResult<TaskListResponse>> Get(int id)
        {
            var response = await _getUseCase.ExecuteAsync(id);
            if (response == null)
                return new NotFoundObjectResult("Registro não encontrado");

            return new OkObjectResult(response);
        }

        [HttpPost]
        public async Task<TaskListResponse> Post([FromBody] TaskListRequest request)
        {
            return await _insertUseCase.ExecuteAsync(request);
        }

        [HttpPost("task")]
        public async Task<TaskResponse> PostTask([FromBody] TaskRequest request)
        {
            return await _insertTaskDetailUseCase.ExecuteAsync(request);
        }

        [HttpGet("weatherforcast")]
        public async Task<ActionResult<WeatherDTO>> GetWeatherForcast()
        {
            var response = await _getWeatherForecastUseCase.ExecuteAsync(string.Empty);

            return new OkObjectResult(response);
        }
    }
}