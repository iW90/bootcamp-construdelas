using TodoList.Core.Entities;

namespace TodoList.Core.Repositories
{
    public interface IRepository
    {
        Task Inserir(TaskList taskList);
        Task<TaskList> GetTaskList(int id);
        Task InserirTask(TaskDetail taskDetail);
    }
}
