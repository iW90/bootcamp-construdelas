using System;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.DTOs
{
    public class LivrosAtrasadosDTO
    {
        public string TituloLivro { get; set; }
        public string NomeAutor { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int DiasEmAtraso { get; set; }
        public decimal ValorMulta { get; set; }
    }
}
