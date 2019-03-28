using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.DAL;
using ProMedi.Models;
using ProMedi.ViewModels;
namespace ProMedi.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Home()
        {
            VmHome home = new VmHome
            {
                About = _context.Abouts.FirstOrDefault(),
                Blogs = _context.Blogs.ToList(),
                Contact = _context.Contacts.FirstOrDefault(),
                Departments = _context.Departments.ToList(),
                Doctors = _context.Doctors.ToList(),
                Facts = _context.Facts.ToList(),
                HomeCards = _context.HomeCards.Take(3).ToList(),
                HomeExperience = _context.HomeExperiences.FirstOrDefault(),
                Setting = _context.Settings.FirstOrDefault()
            };
            return View(home);
        }
       
    }
}