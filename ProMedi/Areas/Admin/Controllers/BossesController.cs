using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProMedi.Areas.Admin.Models;
using ProMedi.DAL;

namespace ProMedi.Areas.Admin.Controllers
{
    public class BossesController : Controller
    {
        private ProMediContext db = new ProMediContext();

        // GET: Admin/Bosses
        public ActionResult Index()
        {
            return View(db.Bosses.ToList());
        }

        // GET: Admin/Bosses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boss boss = db.Bosses.Find(id);
            if (boss == null)
            {
                return HttpNotFound();
            }
            return View(boss);
        }

        // GET: Admin/Bosses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Bosses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fullname,Email,Password")] Boss boss)
        {
            if (ModelState.IsValid)
            {
                db.Bosses.Add(boss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(boss);
        }

        // GET: Admin/Bosses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boss boss = db.Bosses.Find(id);
            if (boss == null)
            {
                return HttpNotFound();
            }
            return View(boss);
        }

        // POST: Admin/Bosses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fullname,Email,Password")] Boss boss)
        {
            if (ModelState.IsValid)
            {
                db.Entry(boss).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(boss);
        }

        // GET: Admin/Bosses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boss boss = db.Bosses.Find(id);
            if (boss == null)
            {
                return HttpNotFound();
            }
            return View(boss);
        }

        // POST: Admin/Bosses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Boss boss = db.Bosses.Find(id);
            db.Bosses.Remove(boss);
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
