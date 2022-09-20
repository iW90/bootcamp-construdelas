using BerthaLutzStore.Core.Entities;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BerthaLutzStore.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task New(Order obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public async Task Update(Order obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
        public async Task Delete(Order obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }
        public async Task<Order> Search(int id)
        {
            return await _context
                .Orders
                .Include(x => x.OrderedItems)
                    .ThenInclude(x => x.Product)
                .Where(x => x.IdOrder == id)
                .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Order>> SearchAll()
        {
            return await _context
                .Orders
                .Include(x => x.OrderedItems)
                    .ThenInclude(x => x.Product)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
