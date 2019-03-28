using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.ViewModels;
namespace ProMedi.Controllers
{
    public class DepartmentController : BaseController
    {
        // GET: Department
        public ActionResult Department(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return HttpNotFound();
            }
            VmDepartment dt = new VmDepartment
            {
                Contact = _context.Contacts.First(),
                Setting = _context.Settings.First(),
                Department= _context.Departments.FirstOrDefault(d => d.Slug == slug)
            };
           

            return View(dt);
        }
    }
}