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
    public class revistas_librosController : ApiController
    {
        private ProyectoEntities db = new ProyectoEntities();

        // GET: api/revistas_libros
        public IQueryable<revistas_libros> Getrevistas_libros()
        {
            return db.revistas_libros;
        }

        // GET: api/revistas_libros/5
        [ResponseType(typeof(revistas_libros))]
        public IHttpActionResult Getrevistas_libros(int id)
        {
            revistas_libros revistas_libros = db.revistas_libros.Find(id);
            if (revistas_libros == null)
            {
                return NotFound();
            }

            return Ok(revistas_libros);
        }

        // PUT: api/revistas_libros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putrevistas_libros(int id, revistas_libros revistas_libros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != revistas_libros.id_Informacion)
            {
                return BadRequest();
            }

            db.Entry(revistas_libros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!revistas_librosExists(id))
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

        // POST: api/revistas_libros
        [ResponseType(typeof(revistas_libros))]
        public IHttpActionResult Postrevistas_libros(revistas_libros revistas_libros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.revistas_libros.Add(revistas_libros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = revistas_libros.id_Informacion }, revistas_libros);
        }

        // DELETE: api/revistas_libros/5
        [ResponseType(typeof(revistas_libros))]
        public IHttpActionResult Deleterevistas_libros(int id)
        {
            revistas_libros revistas_libros = db.revistas_libros.Find(id);
            if (revistas_libros == null)
            {
                return NotFound();
            }

            db.revistas_libros.Remove(revistas_libros);
            db.SaveChanges();

            return Ok(revistas_libros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool revistas_librosExists(int id)
        {
            return db.revistas_libros.Count(e => e.id_Informacion == id) > 0;
        }
    }
}