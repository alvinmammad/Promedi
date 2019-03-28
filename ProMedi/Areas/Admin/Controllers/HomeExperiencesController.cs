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
    public class HomeExperiencesController : Controller
    {
        private ProMediContext db = new ProMediContext();

        // GET: Admin/HomeExperiences
        public ActionResult Index()
        {
            return View(db.HomeExperiences.ToList());
        }

        // GET: Admin/HomeExperiences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeExperience homeExperience = db.HomeExperiences.Find(id);
            if (homeExperience == null)
            {
                return HttpNotFound();
            }
            return View(homeExperience);
        }

        // GET: Admin/HomeExperiences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeExperiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Desc")] HomeExperience homeExperience)
        {
            if (ModelState.IsValid)
            {
                db.HomeExperiences.Add(homeExperience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeExperience);
        }

        // GET: Admin/HomeExperiences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeExperience homeExperience = db.HomeExperiences.Find(id);
            if (homeExperience == null)
            {
                return HttpNotFound();
            }
            return View(homeExperience);
        }

        // POST: Admin/HomeExperiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Desc")] HomeExperience homeExperience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeExperience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeExperience);
        }

        // GET: Admin/HomeExperiences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeExperience homeExperience = db.HomeExperiences.Find(id);
            if (homeExperience == null)
            {
                return HttpNotFound();
            }
            return View(homeExperience);
        }

        // POST: Admin/HomeExperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeExperience homeExperience = db.HomeExperiences.Find(id);
            db.HomeExperiences.Remove(homeExperience);
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
