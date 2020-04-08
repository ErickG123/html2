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
    public class PRODUTOController : Controller
    {
        private SUPERMERCADODBEntities db = new SUPERMERCADODBEntities();

        // GET: PRODUTO
        public ActionResult Index()
        {
            var pRODUTO = db.PRODUTO.Include(p => p.CATEGORIA1);
            return View(pRODUTO.ToList());
        }

        // GET: PRODUTO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // GET: PRODUTO/Create
        public ActionResult Create()
        {
            ViewBag.CATEGORIA = new SelectList(db.CATEGORIA, "IDCATEGORIA", "CATEGORIA1");
            return View();
        }

        // POST: PRODUTO/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDPRODUTO,NOMEPRODUTO,QTDEESTOQUE,PRECOVENDA,DATAVALIDADE,CATEGORIA")] PRODUTO pRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.PRODUTO.Add(pRODUTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CATEGORIA = new SelectList(db.CATEGORIA, "IDCATEGORIA", "CATEGORIA1", pRODUTO.CATEGORIA);
            return View(pRODUTO);
        }

        // GET: PRODUTO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            ViewBag.CATEGORIA = new SelectList(db.CATEGORIA, "IDCATEGORIA", "CATEGORIA1", pRODUTO.CATEGORIA);
            return View(pRODUTO);
        }

        // POST: PRODUTO/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPRODUTO,NOMEPRODUTO,QTDEESTOQUE,PRECOVENDA,DATAVALIDADE,CATEGORIA")] PRODUTO pRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CATEGORIA = new SelectList(db.CATEGORIA, "IDCATEGORIA", "CATEGORIA1", pRODUTO.CATEGORIA);
            return View(pRODUTO);
        }

        // GET: PRODUTO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // POST: PRODUTO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            db.PRODUTO.Remove(pRODUTO);
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
