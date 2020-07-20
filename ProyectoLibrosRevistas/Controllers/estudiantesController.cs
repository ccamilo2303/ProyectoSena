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
    public class estudiantesController : ApiController
    {
        private ProyectoEntities db = new ProyectoEntities();

        // GET: api/estudiantes
        public IQueryable<estudiantes> Getestudiantes()
        {
            return db.estudiantes;
        }

        // GET: api/estudiantes/5
        [ResponseType(typeof(estudiantes))]
        public IHttpActionResult Getestudiantes(int id)
        {
            estudiantes estudiantes = db.estudiantes.Find(id);
            if (estudiantes == null)
            {
                return NotFound();
            }

            return Ok(estudiantes);
        }

        // PUT: api/estudiantes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putestudiantes(int id, estudiantes estudiantes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != estudiantes.id_estudiante)
            {
                return BadRequest();
            }

            db.Entry(estudiantes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!estudiantesExists(id))
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

        // POST: api/estudiantes
        [ResponseType(typeof(estudiantes))]
        public IHttpActionResult Postestudiantes(estudiantes estudiantes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.estudiantes.Add(estudiantes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = estudiantes.id_estudiante }, estudiantes);
        }

        // DELETE: api/estudiantes/5
        [ResponseType(typeof(estudiantes))]
        public IHttpActionResult Deleteestudiantes(int id)
        {
            estudiantes estudiantes = db.estudiantes.Find(id);
            if (estudiantes == null)
            {
                return NotFound();
            }

            db.estudiantes.Remove(estudiantes);
            db.SaveChanges();

            return Ok(estudiantes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool estudiantesExists(int id)
        {
            return db.estudiantes.Count(e => e.id_estudiante == id) > 0;
        }
    }
}