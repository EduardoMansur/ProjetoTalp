using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimos.Model
{
    class Emprestimo
    {
        public int idEmprestimo { get; set; }
        public int idLivro { get; set; }
        public string idUsuario { get; set; }
        public int devolvido { get; set; }
    }
}
