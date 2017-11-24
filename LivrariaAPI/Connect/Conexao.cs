using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LivrariaAPI.Connect
{
    public class Conexao : DbContext
    {
        public Conexao() : base("name=MinhaConexao")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public System.Data.Entity.DbSet<LivrariaAPI.Models.Livro> Livro { get; set; }

        public System.Data.Entity.DbSet<LivrariaAPI.Models.Usuario> Usuario { get; set; }

        public System.Data.Entity.DbSet<LivrariaAPI.Models.Emprestimo> Emprestimo { get; set; }
    }
}