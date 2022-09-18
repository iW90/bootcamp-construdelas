namespace Biblioteca.Application.Models.ListarLivros
{
    public class ListarLivrosResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public int IdAutor { get; set; }
    }
}
