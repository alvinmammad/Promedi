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
    public class HomeCardsController : Controller
    {
        private ProMediContext db = new ProMediContext();

        // GET: Admin/HomeCards
        public ActionResult Index()
        {
            return View(db.HomeCards.ToList());
        }

        // GET: Admin/HomeCards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeCard homeCard = db.HomeCards.Find(id);
            if (homeCard == null)
            {
                return HttpNotFound();
            }
            return View(homeCard);
        }

        // GET: Admin/HomeCards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Photo,Name,Title")] HomeCard homeCard)
        {
            if (ModelState.IsValid)
            {
                db.HomeCards.Add(homeCard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeCard);
        }

        // GET: Admin/HomeCards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeCard homeCard = db.HomeCards.Find(id);
            if (homeCard == null)
            {
                return HttpNotFound();
            }
            return View(homeCard);
        }

        // POST: Admin/HomeCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Photo,Name,Title")] HomeCard homeCard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeCard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeCard);
        }

        // GET: Admin/HomeCards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeCard homeCard = db.HomeCards.Find(id);
            if (homeCard == null)
            {
                return HttpNotFound();
            }
            return View(homeCard);
        }

        // POST: Admin/HomeCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeCard homeCard = db.HomeCards.Find(id);
            db.HomeCards.Remove(homeCard);
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
