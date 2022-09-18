using System.Collections.Generic;

namespace Biblioteca.Core.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public int IdAutor { get; set; }
        public Autor Autor { get; set; }

        public List<Emprestimo> Emprestimos { get; set; }
    }
}
