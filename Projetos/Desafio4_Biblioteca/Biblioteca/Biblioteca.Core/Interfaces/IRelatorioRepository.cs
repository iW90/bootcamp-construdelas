using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Core.DTOs;

namespace Biblioteca.Core.Interfaces
{
    public interface IRelatorioRepository
    {
        Task<IEnumerable<LivrosAtrasadosDTO>> RelatorioLivrosEmAtraso(DateTime? dataInicio, DateTime? dataDevolucao, string nomeUsuario, string tituloLivro);
        Task<IEnumerable<LivroEmprestadoDTO>> RelatorioLivrosEmprestados();
        Task<IEnumerable<LivrosDisponiveisDTO>> RelatorioLivrosDisponiveis();
    }
}
