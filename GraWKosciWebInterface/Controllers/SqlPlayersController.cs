using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GraWKosci.DAL;

namespace GraWKosciWebInterface.Controllers
{
    public class SqlPlayersController : Controller
    {
        private KosciContext db = new KosciContext();

        // GET: SqlPlayers
        public ActionResult Index()
        {
            return View(db.SqlPlayers.ToList());
        }

        // GET: SqlPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SqlPlayer sqlPlayer = db.SqlPlayers.Find(id);
            if (sqlPlayer == null)
            {
                return HttpNotFound();
            }
            return View(sqlPlayer);
        }

        // GET: SqlPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SqlPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Score")] SqlPlayer sqlPlayer)
        {
            if (ModelState.IsValid)
            {
                db.SqlPlayers.Add(sqlPlayer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sqlPlayer);
        }

        // GET: SqlPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SqlPlayer sqlPlayer = db.SqlPlayers.Find(id);
            if (sqlPlayer == null)
            {
                return HttpNotFound();
            }
            return View(sqlPlayer);
        }

        // POST: SqlPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Score")] SqlPlayer sqlPlayer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sqlPlayer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sqlPlayer);
        }

        // GET: SqlPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SqlPlayer sqlPlayer = db.SqlPlayers.Find(id);
            if (sqlPlayer == null)
            {
                return HttpNotFound();
            }
            return View(sqlPlayer);
        }

        // POST: SqlPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SqlPlayer sqlPlayer = db.SqlPlayers.Find(id);
            db.SqlPlayers.Remove(sqlPlayer);
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
