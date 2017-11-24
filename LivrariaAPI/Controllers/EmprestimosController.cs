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
    public class EmprestimosController : ApiController
    {
        private Conexao db = new Conexao();

        // GET: api/Emprestimos
        public IQueryable<Emprestimo> GetEmprestimo()
        {
            return db.Emprestimo;
        }

        // GET: api/Emprestimos/5
        [ResponseType(typeof(Emprestimo))]
        public IHttpActionResult GetEmprestimo(int id)
        {
            Emprestimo emprestimo = db.Emprestimo.Find(id);
            if (emprestimo == null)
            {
                return NotFound();
            }

            return Ok(emprestimo);
        }

        // PUT: api/Emprestimos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmprestimo(int id, Emprestimo emprestimo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != emprestimo.idEmprestimo)
            {
                return BadRequest();
            }

            db.Entry(emprestimo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmprestimoExists(id))
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

        // POST: api/Emprestimos
        [ResponseType(typeof(Emprestimo))]
        public IHttpActionResult PostEmprestimo(Emprestimo emprestimo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Emprestimo.Add(emprestimo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = emprestimo.idEmprestimo }, emprestimo);
        }

        // DELETE: api/Emprestimos/5
        [ResponseType(typeof(Emprestimo))]
        public IHttpActionResult DeleteEmprestimo(int id)
        {
            Emprestimo emprestimo = db.Emprestimo.Find(id);
            if (emprestimo == null)
            {
                return NotFound();
            }

            db.Emprestimo.Remove(emprestimo);
            db.SaveChanges();

            return Ok(emprestimo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmprestimoExists(int id)
        {
            return db.Emprestimo.Count(e => e.idEmprestimo == id) > 0;
        }
    }
}