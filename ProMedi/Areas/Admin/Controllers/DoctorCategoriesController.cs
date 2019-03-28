using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProMedi.DAL;
using ProMedi.Models;

namespace ProMedi.Areas.Admin.Controllers
{
    public class DoctorCategoriesController : Controller
    {
        private ProMediContext db = new ProMediContext();

        // GET: Admin/DoctorCategories
        public ActionResult Index()
        {
            return View(db.DoctorCategories.ToList());
        }

        // GET: Admin/DoctorCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorCategory doctorCategory = db.DoctorCategories.Find(id);
            if (doctorCategory == null)
            {
                return HttpNotFound();
            }
            return View(doctorCategory);
        }

        // GET: Admin/DoctorCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DoctorCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] DoctorCategory doctorCategory)
        {
            if (ModelState.IsValid)
            {
                db.DoctorCategories.Add(doctorCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctorCategory);
        }

        // GET: Admin/DoctorCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorCategory doctorCategory = db.DoctorCategories.Find(id);
            if (doctorCategory == null)
            {
                return HttpNotFound();
            }
            return View(doctorCategory);
        }

        // POST: Admin/DoctorCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] DoctorCategory doctorCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctorCategory);
        }

        // GET: Admin/DoctorCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorCategory doctorCategory = db.DoctorCategories.Find(id);
            if (doctorCategory == null)
            {
                return HttpNotFound();
            }
            return View(doctorCategory);
        }

        // POST: Admin/DoctorCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctorCategory doctorCategory = db.DoctorCategories.Find(id);
            db.DoctorCategories.Remove(doctorCategory);
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
