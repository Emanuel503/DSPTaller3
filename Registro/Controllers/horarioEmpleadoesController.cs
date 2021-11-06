using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Registro.Models;

namespace Registro.Controllers
{
    public class horarioEmpleadoesController : Controller
    {
        private registroEnviosEntities db = new registroEnviosEntities();

        // GET: horarioEmpleadoes
        public ActionResult Index()
        {
            var horarioEmpleado = db.horarioEmpleado.Include(h => h.empleado).Include(h => h.horario);
            return View(horarioEmpleado.ToList());
        }

        // GET: horarioEmpleadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            horarioEmpleado horarioEmpleado = db.horarioEmpleado.Find(id);
            if (horarioEmpleado == null)
            {
                return HttpNotFound();
            }
            return View(horarioEmpleado);
        }

        // GET: horarioEmpleadoes/Create
        public ActionResult Create()
        {
            ViewBag.idEmpleado = new SelectList(db.empleado, "idEmpleado", "nombre");
            ViewBag.idHorario = new SelectList(db.horario, "idHorario", "tipo");
            return View();
        }

        // POST: horarioEmpleadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idHorarioEmpleado,idEmpleado,idHorario,mes,ano,semanaMes,horaExtraTrabajadas")] horarioEmpleado horarioEmpleado)
        {
            if (ModelState.IsValid)
            {
                db.horarioEmpleado.Add(horarioEmpleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idEmpleado = new SelectList(db.empleado, "idEmpleado", "nombre", horarioEmpleado.idEmpleado);
            ViewBag.idHorario = new SelectList(db.horario, "idHorario", "tipo", horarioEmpleado.idHorario);
            return View(horarioEmpleado);
        }

        // GET: horarioEmpleadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            horarioEmpleado horarioEmpleado = db.horarioEmpleado.Find(id);
            if (horarioEmpleado == null)
            {
                return HttpNotFound();
            }
            ViewBag.idEmpleado = new SelectList(db.empleado, "idEmpleado", "nombre", horarioEmpleado.idEmpleado);
            ViewBag.idHorario = new SelectList(db.horario, "idHorario", "tipo", horarioEmpleado.idHorario);
            return View(horarioEmpleado);
        }

        // POST: horarioEmpleadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idHorarioEmpleado,idEmpleado,idHorario,mes,ano,semanaMes,horaExtraTrabajadas")] horarioEmpleado horarioEmpleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horarioEmpleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idEmpleado = new SelectList(db.empleado, "idEmpleado", "nombre", horarioEmpleado.idEmpleado);
            ViewBag.idHorario = new SelectList(db.horario, "idHorario", "tipo", horarioEmpleado.idHorario);
            return View(horarioEmpleado);
        }

        // GET: horarioEmpleadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            horarioEmpleado horarioEmpleado = db.horarioEmpleado.Find(id);
            if (horarioEmpleado == null)
            {
                return HttpNotFound();
            }
            return View(horarioEmpleado);
        }

        // POST: horarioEmpleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            horarioEmpleado horarioEmpleado = db.horarioEmpleado.Find(id);
            db.horarioEmpleado.Remove(horarioEmpleado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
