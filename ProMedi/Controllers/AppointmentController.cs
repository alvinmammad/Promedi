using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.ViewModels;
using ProMedi.DAL;
using ProMedi.Models;

namespace ProMedi.Controllers
{
    public class AppointmentController : BaseController
    {
        // GET: Appointment
        public ActionResult Appointment()
        {
            VmAppointment appointment = new VmAppointment
            {
                Setting = _context.Settings.FirstOrDefault(),
                Departments = _context.Departments.ToList(),
                Doctors = _context.Doctors.ToList()
            };

            return View(appointment);
        }

        [HttpPost]
        public ActionResult Appointment(Appointment appointment)
        {
            
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            return RedirectToAction("home","home");
        }
    }
}