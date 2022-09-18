using System.Collections.Generic;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Core.Interfaces
{
    public interface IAlarmRepository : IRepository<Alarm>
    {
        Task InsertAlarm(List<Alarm> alarm);
    }
}
