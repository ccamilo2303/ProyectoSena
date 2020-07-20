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
using ProyectoLibrosRevistas.Models;

namespace ProyectoLibrosRevistas.Controllers
{
    public class tipo_revistasController : ApiController
    {
        private ProyectoEntities db = new ProyectoEntities();

        // GET: api/tipo_revistas
        public IQueryable<tipo_revistas> Gettipo_revistas()
        {
            return db.tipo_revistas;
        }

        // GET: api/tipo_revistas/5
        [ResponseType(typeof(tipo_revistas))]
        public IHttpActionResult Gettipo_revistas(int id)
        {
            tipo_revistas tipo_revistas = db.tipo_revistas.Find(id);
            if (tipo_revistas == null)
            {
                return NotFound();
            }

            return Ok(tipo_revistas);
        }

        // PUT: api/tipo_revistas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttipo_revistas(int id, tipo_revistas tipo_revistas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipo_revistas.id_tipo)
            {
                return BadRequest();
            }

            db.Entry(tipo_revistas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tipo_revistasExists(id))
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

        // POST: api/tipo_revistas
        [ResponseType(typeof(tipo_revistas))]
        public IHttpActionResult Posttipo_revistas(tipo_revistas tipo_revistas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tipo_revistas.Add(tipo_revistas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tipo_revistasExists(tipo_revistas.id_tipo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tipo_revistas.id_tipo }, tipo_revistas);
        }

        // DELETE: api/tipo_revistas/5
        [ResponseType(typeof(tipo_revistas))]
        public IHttpActionResult Deletetipo_revistas(int id)
        {
            tipo_revistas tipo_revistas = db.tipo_revistas.Find(id);
            if (tipo_revistas == null)
            {
                return NotFound();
            }

            db.tipo_revistas.Remove(tipo_revistas);
            db.SaveChanges();

            return Ok(tipo_revistas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tipo_revistasExists(int id)
        {
            return db.tipo_revistas.Count(e => e.id_tipo == id) > 0;
        }
    }
}