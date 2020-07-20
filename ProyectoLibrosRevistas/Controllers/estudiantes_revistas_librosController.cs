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
    public class estudiantes_revistas_librosController : ApiController
    {
        private ProyectoEntities db = new ProyectoEntities();

        // GET: api/estudiantes_revistas_libros
        public IQueryable<estudiantes_revistas_libros> Getestudiantes_revistas_libros()
        {
            return db.estudiantes_revistas_libros;
        }

        // GET: api/estudiantes_revistas_libros/5
        [ResponseType(typeof(estudiantes_revistas_libros))]
        public IHttpActionResult Getestudiantes_revistas_libros(int id)
        {
            estudiantes_revistas_libros estudiantes_revistas_libros = db.estudiantes_revistas_libros.Find(id);
            if (estudiantes_revistas_libros == null)
            {
                return NotFound();
            }

            return Ok(estudiantes_revistas_libros);
        }

        // PUT: api/estudiantes_revistas_libros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putestudiantes_revistas_libros(int id, estudiantes_revistas_libros estudiantes_revistas_libros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != estudiantes_revistas_libros.id)
            {
                return BadRequest();
            }

            db.Entry(estudiantes_revistas_libros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!estudiantes_revistas_librosExists(id))
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

        // POST: api/estudiantes_revistas_libros
        [ResponseType(typeof(estudiantes_revistas_libros))]
        public IHttpActionResult Postestudiantes_revistas_libros(estudiantes_revistas_libros estudiantes_revistas_libros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.estudiantes_revistas_libros.Add(estudiantes_revistas_libros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = estudiantes_revistas_libros.id }, estudiantes_revistas_libros);
        }

        // DELETE: api/estudiantes_revistas_libros/5
        [ResponseType(typeof(estudiantes_revistas_libros))]
        public IHttpActionResult Deleteestudiantes_revistas_libros(int id)
        {
            estudiantes_revistas_libros estudiantes_revistas_libros = db.estudiantes_revistas_libros.Find(id);
            if (estudiantes_revistas_libros == null)
            {
                return NotFound();
            }

            db.estudiantes_revistas_libros.Remove(estudiantes_revistas_libros);
            db.SaveChanges();

            return Ok(estudiantes_revistas_libros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool estudiantes_revistas_librosExists(int id)
        {
            return db.estudiantes_revistas_libros.Count(e => e.id == id) > 0;
        }
    }
}