using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infra.Database;

namespace Biblioteca.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Atualizar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Usuario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
