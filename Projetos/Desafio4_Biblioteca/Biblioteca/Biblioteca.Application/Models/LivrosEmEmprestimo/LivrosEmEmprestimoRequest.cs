using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Models.LivrosEmEmprestimo
{
    public class LivrosEmEmprestimoRequest
    {
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
    }
}
