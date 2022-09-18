using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.DTOs
{
    public class LivrosDisponiveisDTO
    {
        public string TituloLivro { get; set; }
        public string NomeAutor { get; set; }
        public int QtdDisponivel { get; set; }
        public int QtdEmp { get; set; }
    }
}
