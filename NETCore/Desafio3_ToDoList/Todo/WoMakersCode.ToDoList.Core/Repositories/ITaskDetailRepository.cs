using System.Threading.Tasks;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Core.Repositories
{
    public interface ITaskDetailRepository:IRepository<TaskDetail>
    {
        Task InserirTask(TaskDetail taskDetail);
    }
}
