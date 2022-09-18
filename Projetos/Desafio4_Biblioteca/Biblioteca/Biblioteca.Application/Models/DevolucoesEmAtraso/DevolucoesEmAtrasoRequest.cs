using System;

namespace Biblioteca.Application.Models.DevolucoesEmAtraso
{
    public class DevolucoesEmAtrasoFiltroRequest
    {
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public string NomeUsuario { get; set; }
        public string TituloLivro { get; set; }
    }
}
