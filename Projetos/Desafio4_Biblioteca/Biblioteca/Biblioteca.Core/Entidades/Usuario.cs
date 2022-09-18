using System.Collections.Generic;

namespace Biblioteca.Core.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}