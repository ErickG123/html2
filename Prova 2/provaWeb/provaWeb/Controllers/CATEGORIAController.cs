using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using provaWeb.Models;

namespace provaWeb.Controllers
{
    public class CATEGORIAController : Controller
    {
        private SUPERMERCADODBEntities db = new SUPERMERCADODBEntities();

        // GET: CATEGORIA
        public ActionResult Index()
        {
            return View(db.CATEGORIA.ToList());
        }

        // GET: CATEGORIA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORIA cATEGORIA = db.CATEGORIA.Find(id);
            if (cATEGORIA == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORIA);
        }

        // GET: CATEGORIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CATEGORIA/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDCATEGORIA,CATEGORIA1")] CATEGORIA cATEGORIA)
        {
            if (ModelState.IsValid)
            {
                db.CATEGORIA.Add(cATEGORIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cATEGORIA);
        }

        // GET: CATEGORIA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORIA cATEGORIA = db.CATEGORIA.Find(id);
            if (cATEGORIA == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORIA);
        }

        // POST: CATEGORIA/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDCATEGORIA,CATEGORIA1")] CATEGORIA cATEGORIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cATEGORIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cATEGORIA);
        }

        // GET: CATEGORIA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORIA cATEGORIA = db.CATEGORIA.Find(id);
            if (cATEGORIA == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORIA);
        }

        // POST: CATEGORIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CATEGORIA cATEGORIA = db.CATEGORIA.Find(id);
            db.CATEGORIA.Remove(cATEGORIA);
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
