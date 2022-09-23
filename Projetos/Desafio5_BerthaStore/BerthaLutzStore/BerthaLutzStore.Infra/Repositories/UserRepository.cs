using BerthaLutzStore.Core.Entities;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BerthaLutzStore.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context; //Vincula-se ao BD implementado pelo Migrations

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task New(User obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public async Task Update(User obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
        public async Task Delete(User obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }
        public async Task<User> Search(int id)
        {
            return await _context
                .Users
                .Include(x => x.Orders)
                .Where(x => x.IdUser == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<User> SearchAux(int id)
        {
            return await _context
                .Users
                .Where(x => x.IdUser == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> SearchAll()
        {
            return await _context
                .Users
                .Include(x => x.Orders)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
