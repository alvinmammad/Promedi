using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.DAL;

namespace ProMedi.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ProMediContext _context = new ProMediContext();
        // GET: Base
        public BaseController()
        {
            ViewBag.Setting = _context.Settings.First();
            ViewBag.Tags = _context.Tags.OrderByDescending(t=>t.Name).ToList();
            ViewBag.Latest = _context.Blogs.Include("Author").OrderByDescending(l => l.Date).Take(3).ToList();
            
            ViewBag.Departments = _context.Departments.ToList();
            
        }
    }
}