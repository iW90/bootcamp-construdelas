using System.Threading.Tasks;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Core.Interfaces
{
    public interface ITaskDetailRepository : IRepository<TaskDetail>
    {
        Task InserirTask(TaskDetail taskDetail);
    }
}
