using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProMedi.Areas.Admin.Filters;
using ProMedi.DAL;
using ProMedi.Models;

namespace ProMedi.Areas.Admin.Controllers
{
    [Auth]
    public class AboutBodiesController : Controller
    {
        private ProMediContext db = new ProMediContext();

        // GET: Admin/AboutBodies
        public ActionResult Index()
        {
            return View(db.AboutBodies.ToList());
        }

        // GET: Admin/AboutBodies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutBody aboutBody = db.AboutBodies.Find(id);
            if (aboutBody == null)
            {
                return HttpNotFound();
            }
            return View(aboutBody);
        }

        // GET: Admin/AboutBodies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutBodies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Desc")] AboutBody aboutBody)
        {
            if (ModelState.IsValid)
            {
                db.AboutBodies.Add(aboutBody);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutBody);
        }

        // GET: Admin/AboutBodies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutBody aboutBody = db.AboutBodies.Find(id);
            if (aboutBody == null)
            {
                return HttpNotFound();
            }
            return View(aboutBody);
        }

        // POST: Admin/AboutBodies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Desc")] AboutBody aboutBody)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutBody).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutBody);
        }

        // GET: Admin/AboutBodies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutBody aboutBody = db.AboutBodies.Find(id);
            if (aboutBody == null)
            {
                return HttpNotFound();
            }
            return View(aboutBody);
        }

        // POST: Admin/AboutBodies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutBody aboutBody = db.AboutBodies.Find(id);
            db.AboutBodies.Remove(aboutBody);
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
