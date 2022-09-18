using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Core.DTOs;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infra.Database;

namespace Biblioteca.Infra.Repositories
{
    public class RelatorioRepository : IRelatorioRepository
    {
        private readonly ApplicationContext _context;

        public RelatorioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LivrosAtrasadosDTO>> RelatorioLivrosEmAtraso(DateTime? dataInicio, DateTime? dataDevolucao, string nomeUsuario, string tituloLivro)
        {
            var registros = _context
                .Emprestimos
                .Include(i => i.Livro)
                    .ThenInclude(ti => ti.Autor)
                .Include(i => i.Usuario)
                .AsNoTracking()
                .AsQueryable();

            if (dataInicio != null)
                registros = registros.Where(w => w.DataEmprestimo == dataInicio);

            if (!string.IsNullOrEmpty(tituloLivro))
                registros = registros.Where(w => w.Livro.Titulo.Contains(tituloLivro));

            var resposta = await registros
            .Select(s => new LivrosAtrasadosDTO()
            {
                TituloLivro = s.Livro.Titulo,
                NomeAutor = s.Livro.Autor.Nome,
                NomeUsuario = s.Usuario.Nome,
                DataEmprestimo = s.DataEmprestimo,
                DataDevolucao = s.DataEmprestimo.AddDays(7),
                DiasEmAtraso = (DateTime.Now - s.DataEmprestimo.AddDays(7)).Days,
                ValorMulta = (DateTime.Now - s.DataEmprestimo.AddDays(7)).Days * 0.5M
            })
                .ToListAsync();

            return resposta;
        }

        public async Task<IEnumerable<LivroEmprestadoDTO>> RelatorioLivrosEmprestados()
        {
            return new List<LivroEmprestadoDTO>();
        }

        public async Task<IEnumerable<LivrosDisponiveisDTO>> RelatorioLivrosDisponiveis()
        {
            return new List<LivrosDisponiveisDTO>();
        }
    }
}
