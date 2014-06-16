using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonsterHelper.Models;

namespace MonsterHelper.Controllers
{
    public class TreinoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Treino/
        public ActionResult Index()
        {
            return View(db.Treinos.ToList());
        }

        // GET: /Treino/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treino treino = db.Treinos.Find(id);
            if (treino == null)
            {
                return HttpNotFound();
            }
            return View(treino);
        }

        // GET: /Treino/Create
        public ActionResult Create()
        {

            return View(new TreinoViewModel());
        }

        // POST: /Treino/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TreinoViewModel treinoViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Treinos.Add(treinoViewModel.Treino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(treinoViewModel);
        }

        // GET: /Treino/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treino treino = db.Treinos.Find(id);
            if (treino == null)
            {
                return HttpNotFound();
            }
            return View(treino);
        }

        // POST: /Treino/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="TreinoID,Nome")] Treino treino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(treino);
        }

        // GET: /Treino/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treino treino = db.Treinos.Find(id);
            if (treino == null)
            {
                return HttpNotFound();
            }
            return View(treino);
        }

        // POST: /Treino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Treino treino = db.Treinos.Find(id);
            db.Treinos.Remove(treino);
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
