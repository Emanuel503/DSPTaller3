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
using Registro.Models;

namespace Registro.Controllers
{
    public class empleadoesWebServiceController : ApiController
    {
        private registroEnviosEntities db = new registroEnviosEntities();

        // GET: api/empleadoesWebService
        public IQueryable<empleado> Getempleado()
        {
            return db.empleado;
        }

        // GET: api/empleadoesWebService/5
        [ResponseType(typeof(empleado))]
        public IHttpActionResult Getempleado(int id)
        {
            empleado empleado = db.empleado.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }

            return Ok(empleado);
        }

        // PUT: api/empleadoesWebService/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putempleado(int id, empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empleado.idEmpleado)
            {
                return BadRequest();
            }

            db.Entry(empleado).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!empleadoExists(id))
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

        // POST: api/empleadoesWebService
        [ResponseType(typeof(empleado))]
        public IHttpActionResult Postempleado(empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.empleado.Add(empleado);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empleado.idEmpleado }, empleado);
        }

        // DELETE: api/empleadoesWebService/5
        [ResponseType(typeof(empleado))]
        public IHttpActionResult Deleteempleado(int id)
        {
            empleado empleado = db.empleado.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }

            db.empleado.Remove(empleado);
            db.SaveChanges();

            return Ok(empleado);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool empleadoExists(int id)
        {
            return db.empleado.Count(e => e.idEmpleado == id) > 0;
        }
    }
}