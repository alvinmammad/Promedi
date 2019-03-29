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
    public class AboutFeaturesController : Controller
    {
        private ProMediContext db = new ProMediContext();

        // GET: Admin/AboutFeatures
        public ActionResult Index()
        {
            return View(db.AboutFeatures.ToList());
        }

        // GET: Admin/AboutFeatures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutFeature aboutFeature = db.AboutFeatures.Find(id);
            if (aboutFeature == null)
            {
                return HttpNotFound();
            }
            return View(aboutFeature);
        }

        // GET: Admin/AboutFeatures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutFeatures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title")] AboutFeature aboutFeature)
        {
            if (ModelState.IsValid)
            {
                db.AboutFeatures.Add(aboutFeature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutFeature);
        }

        // GET: Admin/AboutFeatures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutFeature aboutFeature = db.AboutFeatures.Find(id);
            if (aboutFeature == null)
            {
                return HttpNotFound();
            }
            return View(aboutFeature);
        }

        // POST: Admin/AboutFeatures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title")] AboutFeature aboutFeature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutFeature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutFeature);
        }

        // GET: Admin/AboutFeatures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutFeature aboutFeature = db.AboutFeatures.Find(id);
            if (aboutFeature == null)
            {
                return HttpNotFound();
            }
            return View(aboutFeature);
        }

        // POST: Admin/AboutFeatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutFeature aboutFeature = db.AboutFeatures.Find(id);
            db.AboutFeatures.Remove(aboutFeature);
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
