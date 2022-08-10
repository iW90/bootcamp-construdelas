using System.Threading.Tasks;
using WoMakersCode.ToDoList.Core.Entities;
using WoMakersCode.ToDoList.Core.Repositories;
using WoMakersCode.ToDoList.Infra.Database;

namespace WoMakersCode.ToDoList.Infra.Repositories
{
    public class ToDoListRepository : ITaskDetailRepository
    {
        private readonly ApplicationContext _context;

        public ToDoListRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Task InserirTask(TaskDetail taskDetail)
        {
            _context.Add(taskDetail);

            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
