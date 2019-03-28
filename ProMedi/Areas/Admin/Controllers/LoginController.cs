using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.DAL;
using ProMedi.Areas.Admin.Models;
using System.Web.Helpers;

namespace ProMedi.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        

        // GET: Admin/Login
        private readonly ProMediContext _context = new ProMediContext();

        // GET: Manage/Login
        public ActionResult Index()
        {
            if (Session["AdminLogin"] != null)
            {
                return RedirectToAction("index", "blogs");
            }
            return View();
        }

        public ActionResult Login(Boss admin)
        {
            if (string.IsNullOrEmpty(admin.Email) || string.IsNullOrEmpty(admin.Password))
            {
                Session["LoginError"] = "E-poçt və ya şifrə boş olmamalıdır !";
                return RedirectToAction("index");
            }

            Boss adm = _context.Bosses.FirstOrDefault(a => a.Email == admin.Email);
            if (adm != null)
            {
                if (Crypto.VerifyHashedPassword(adm.Password, admin.Password))
                {
                    Session["AdminLogin"] = true;
                    Session["Admin"] = adm;
                    return RedirectToAction("index", "blog");
                }
            }

            Session["LoginError"] = "E-poçt və ya şifrə səhv daxil olunub !";
            return RedirectToAction("index");
        }
    }
}