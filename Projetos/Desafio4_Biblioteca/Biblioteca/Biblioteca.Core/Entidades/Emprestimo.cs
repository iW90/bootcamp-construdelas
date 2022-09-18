using System;

namespace Biblioteca.Core.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
    }
}
