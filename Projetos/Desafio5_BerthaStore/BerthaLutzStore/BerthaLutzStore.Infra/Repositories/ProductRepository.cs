using BerthaLutzStore.Core.Entities;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BerthaLutzStore.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task New(Product obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public async Task Update(Product obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
        public async Task Delete(Product obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }
        public async Task<Product> Search(int id)
        {
            return await _context
                .Products
                .Where(x => x.IdProduct == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<Product> SearchAux(int id)
        {
            return await _context
                .Products
                .Where(x => x.IdProduct == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> SearchAll()
        {
            return await _context
                .Products
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
