using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.ViewModels;

namespace ProMedi.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult About()
        {
            VmAbout about = new VmAbout
            {
                Setting = _context.Settings.First(),
                About = _context.Abouts.First(),
                AboutBody = _context.AboutBodies.First(),
                AboutFeatures = _context.AboutFeatures.ToList(),
                Doctors = _context.Doctors.ToList(),
                Facts = _context.Facts.ToList(),
                Cards = _context.Cards.ToList()
            };
            return View(about);
        }
    }
}