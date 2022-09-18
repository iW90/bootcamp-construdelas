using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Application.Models.DevolucoesEmAtraso;
using Biblioteca.Application.Models.LivrosDisponiveis;
using Biblioteca.Application.Models.LivrosEmEmprestimo;
using Biblioteca.Application.UseCases;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/relatorios")]
    public class RelatorioController : ControllerBase
    {
        private readonly IUseCaseAsync<DevolucoesEmAtrasoFiltroRequest, List<DevolucoesEmAtrasoResponse>> _useCaseRelatorioDevolucoesEmAtraso;
        private readonly IUseCaseAsync<LivrosDisponiveisRequest, List<LivrosDisponiveisResponse>> _useCaseRelatorioLivrosDisponiveis;
        private readonly IUseCaseAsync<LivrosEmEmprestimoRequest, List<LivrosEmEmprestimoResponse>> _useCaseRelatorioLivrosEmEmprestimo;
        public RelatorioController(IUseCaseAsync<DevolucoesEmAtrasoFiltroRequest, List<DevolucoesEmAtrasoResponse>> useCaseRelatorioDevolucoesEmAtraso,
            IUseCaseAsync<LivrosDisponiveisRequest, List<LivrosDisponiveisResponse>> useCaseRelatorioLivrosDisponiveis,
            IUseCaseAsync<LivrosEmEmprestimoRequest, List<LivrosEmEmprestimoResponse>> useCaseRelatorioLivrosEmEmprestimo)
        {
            _useCaseRelatorioDevolucoesEmAtraso = useCaseRelatorioDevolucoesEmAtraso;
            _useCaseRelatorioLivrosDisponiveis = useCaseRelatorioLivrosDisponiveis;
            _useCaseRelatorioLivrosEmEmprestimo = useCaseRelatorioLivrosEmEmprestimo;
        }

        // Traga os livros que estao com as devolucoes em atraso e a multa a ser paga, considerando que o livro deve ser devolvido em 7 dias e o valor da multa e de 0,50 por dia.
        // Deve-se ter um filtro por data de inicio e data fim da devolucao (se deixar em branco deve vir todos), nome do usuario, nome do livro
        // Trazer no relatorio: titulo do livro, autor, usuario, data de emprestimo, data que deveria ter sido devolvido, dias em atraso e valor da multa
        [HttpGet("devolucoes-em-atraso")]
        public async Task<ActionResult<List<DevolucoesEmAtrasoResponse>>> Get([FromQuery] DevolucoesEmAtrasoFiltroRequest request)
        {
            return await _useCaseRelatorioDevolucoesEmAtraso.ExecuteAsync(request);
        }

        // Traga todos os livros que estao emprestados mas nao atrasados e a possivel data de devolucao
        // Filtro por data de inicio e data fim
        // Trazer no relatorio: titulo do livro, autor, usuario, data de emprestimo, data a ser devolvido
        [HttpGet("livros-em-emprestimo")]
        public async Task<ActionResult<List<LivrosEmEmprestimoResponse>>> Get([FromQuery] LivrosEmEmprestimoRequest request)
        {
            return await _useCaseRelatorioLivrosEmEmprestimo.ExecuteAsync(request);
        }

        // Traga todos os livros (titulo, autor), sua quantidade disponivel, a quantidade em emprestimo
        // Filtro por titulo e autor
        [HttpGet("livros-disponiveis")]
        public async Task<ActionResult<List<LivrosDisponiveisResponse>>> Get([FromQuery] LivrosDisponiveisRequest request)
        {
            return await _useCaseRelatorioLivrosDisponiveis.ExecuteAsync(request);
        }
    }
}
