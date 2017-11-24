using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivrariaAPI.Models
{
    public class Usuario
    {
        [Key]
        public string email { get; set; }
        public string senha { get; set; }
        public string cep { get; set; }
    }
}