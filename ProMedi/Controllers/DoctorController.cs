using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.Models;
using ProMedi.DAL;

namespace ProMedi.Controllers
{
    public class DoctorController : BaseController
    {
        // GET: Doctor
        public ActionResult Doctor()
        {
            var doctor = _context.Doctors.Include("Category").ToList();
            return View(doctor);
        }
        public ActionResult DoctorDetails(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return HttpNotFound();
            }
            var doctor = _context.Doctors.Include("Category").FirstOrDefault(d => d.Slug==slug);
            if (doctor==null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }
    }
}