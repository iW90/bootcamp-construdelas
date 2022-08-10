using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Core.Entities;
using WoMakersCode.ToDoList.Core.Filters;
using WoMakersCode.ToDoList.Core.Repositories;
using WoMakersCode.ToDoList.Infra.Database;

namespace WoMakersCode.ToDoList.Infra.Repositories
{
    public class TaskListRepository : ITaskListRepository
    {
        private readonly ApplicationContext _context;

        public TaskListRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskList>> GetAll()
        {
            return await _context
               .TaskLists
               .AsNoTracking()
               .ToListAsync();
        }

        public async Task<TaskList> GetById(GetFilter filter)
        {
            var result = _context
                 .TaskLists
                 .Include(id => id.Details)
                 .AsQueryable();

            if (filter.Id != 0)
            {
                result = result.Where(w => w.Id == filter.Id);
            }
            if (!string.IsNullOrEmpty(filter.Pesquisa))
            {
                result = result.Where(w => w.ListName.Contains(filter.Pesquisa));
            }

            return await result
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task Insert(TaskList taskList)
        {
            _context.Add(taskList);
            await _context.SaveChangesAsync();
        }
    }
}
