using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infra.Database;

namespace Biblioteca.Infra.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationContext _context;
        public LivroRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Atualizar(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Livro> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Livro>> ListarTodos()
        {
            return await _context
                .Livros
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
