using System.Threading.Tasks;
using TodoList.Core.Entities;
using TodoList.Core.Repositories;
using TodoList.Infra.Database;

namespace TodoList.Infra.Repositories
{
    public class ToDoListRepository : IRepository
    {
        private readonly ApplicationContext _context;

        public ToDoListRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Task<TaskList> GetTaskList(int id)
        {
            return Task.FromResult(_context.Find<TaskList>(id));
        }

        public Task Inserir(TaskList taskList)
        {
            _context.Add(taskList);
            _context.SaveChanges();

            return Task.CompletedTask;
        }



    }
}
