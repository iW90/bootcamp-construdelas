using System.Collections.Generic;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Core.Entities;
using WoMakersCode.ToDoList.Core.Filters;

namespace WoMakersCode.ToDoList.Core.Interfaces
{
    public interface ITaskListRepository : IRepository<TaskList>
    {
        Task<IEnumerable<TaskList>> GetAll();
        Task<TaskList> GetById(GetFilter filter);
        Task Insert(TaskList taskList);
    }
}
