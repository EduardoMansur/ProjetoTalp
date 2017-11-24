using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LivrariaAPI.Connect;
using LivrariaAPI.Models;

namespace LivrariaAPI.Controllers
{
    public class LivrosController : ApiController
    {
        private Conexao db = new Conexao();

        // GET: api/Livros
        public IQueryable<Livro> GetLivro()
        {
            return db.Livro;
        }

        // GET: api/Livros/5
        [ResponseType(typeof(Livro))]
        public IHttpActionResult GetLivro(int id)
        {
            Livro livro = db.Livro.Find(id);
            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }
        /// <summary>
        /// Perquisa Livro pelo email.
        /// </summary>
        /// <param name="nome">Nome a ser pesquisado.</param>
        /// <returns></returns>
        [Route("api/Livros/search/{email}")]
        public IQueryable<Livro> GetMaterialbyName(string email)
        {
            return db.Livro.Where(e => e.idUsuario.Contains(email));
        }

        // PUT: api/Livros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLivro(int id, Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != livro.idLivro)
            {
                return BadRequest();
            }

            db.Entry(livro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Livros
        [ResponseType(typeof(Livro))]
        public IHttpActionResult PostLivro(Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Livro.Add(livro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = livro.idLivro }, livro);
        }

        // DELETE: api/Livros/5
        [ResponseType(typeof(Livro))]
        public IHttpActionResult DeleteLivro(int id)
        {
            Livro livro = db.Livro.Find(id);
            if (livro == null)
            {
                return NotFound();
            }

            db.Livro.Remove(livro);
            db.SaveChanges();

            return Ok(livro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LivroExists(int id)
        {
            return db.Livro.Count(e => e.idLivro == id) > 0;
        }
    }
}