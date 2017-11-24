using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivrariaAPI.Models
{
    public class Emprestimo
    {
        [Key]
        public int idEmprestimo { get; set; }
        public int idLivro { get; set; }
        public string idUsuario { get; set; }
        public int devolvido { get; set; }
    }
}