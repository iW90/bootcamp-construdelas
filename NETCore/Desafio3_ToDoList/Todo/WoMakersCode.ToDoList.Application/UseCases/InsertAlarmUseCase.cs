using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Core.Entities;
using WoMakersCode.ToDoList.Core.Repositories;

namespace WoMakersCode.ToDoList.Application.UseCases
{
    public class InsertAlarmUseCase : IUseCaseAsync<List<InsertAlarmRequest>, InsertAlarmResponse>
    {
        private readonly IAlarmRepository _alarmRepository;
        private readonly IMapper _mapper;

        public InsertAlarmUseCase(IAlarmRepository alarmRepository, IMapper mapper)
        {
            _alarmRepository = alarmRepository;
            _mapper = mapper;
        }
        public async Task<InsertAlarmResponse>ExecuteAsync(List<InsertAlarmRequest> request)
        {
            if (request == null)
                return null;

            var alarm = _mapper.Map<List<Alarm>>(request);

            await _alarmRepository.InsertAlarm(alarm);
            return new InsertAlarmResponse();
        }
    }
}
