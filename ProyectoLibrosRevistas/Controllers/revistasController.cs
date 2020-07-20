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
    public class revistasController : ApiController
    {
        private ProyectoEntities db = new ProyectoEntities();

        // GET: api/revistas
        public IQueryable<revistas> Getrevistas()
        {
            return db.revistas;
        }

        // GET: api/revistas/5
        [ResponseType(typeof(revistas))]
        public IHttpActionResult Getrevistas(int id)
        {
            revistas revistas = db.revistas.Find(id);
            if (revistas == null)
            {
                return NotFound();
            }

            return Ok(revistas);
        }

        // PUT: api/revistas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putrevistas(int id, revistas revistas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != revistas.id_revista)
            {
                return BadRequest();
            }

            db.Entry(revistas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!revistasExists(id))
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

        // POST: api/revistas
        [ResponseType(typeof(revistas))]
        public IHttpActionResult Postrevistas(revistas revistas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.revistas.Add(revistas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = revistas.id_revista }, revistas);
        }

        // DELETE: api/revistas/5
        [ResponseType(typeof(revistas))]
        public IHttpActionResult Deleterevistas(int id)
        {
            revistas revistas = db.revistas.Find(id);
            if (revistas == null)
            {
                return NotFound();
            }

            db.revistas.Remove(revistas);
            db.SaveChanges();

            return Ok(revistas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool revistasExists(int id)
        {
            return db.revistas.Count(e => e.id_revista == id) > 0;
        }
    }
}