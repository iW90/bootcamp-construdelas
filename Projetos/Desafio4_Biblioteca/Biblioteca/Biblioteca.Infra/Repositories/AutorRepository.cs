using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infra.Database;

namespace Biblioteca.Infra.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly ApplicationContext _context;

        public AutorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Atualizar(Autor obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(Autor obj)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Autor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task<Autor> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Autor>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
