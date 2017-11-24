using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivrariaAPI.Models
{
    public class Livro
    {
        [Key]
        public int idLivro { get; set; }
        public string nome { get; set; }
        public string editora { get; set; }
        public string idUsuario { get; set; }
    }
}