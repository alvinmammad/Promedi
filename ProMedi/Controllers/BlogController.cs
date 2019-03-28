using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.Models;
using ProMedi.DAL;
using ProMedi.ViewModels;

namespace ProMedi.Controllers
{
    public class BlogController : BaseController
    {
        // GET: Blog
        public ActionResult Blog(int? category , int page = 1)
        {
            VmBlog vm = new VmBlog();
            vm.TotalPage = Convert.ToInt32(Math.Ceiling(_context.Blogs.Count() / 8.0));
            if (page<1 || page>vm.TotalPage)
            {
                return HttpNotFound();
            }
            vm.Blogs = _context.Blogs.Include("Author").Where(c=>category!=null?c.CategoryID==category:true).OrderByDescending(b => b.Date).Skip((page - 1) * 8).Take(8).ToList();
            vm.Categories = _context.Categories.ToList();
            vm.ActivePage = page;
            return View(vm);
        }

        public ActionResult BlogDetails(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return HttpNotFound();
            }

            var blog = _context.Blogs.Include("Author").Include("Category").FirstOrDefault(s => s.Slug == slug);
            ViewBag.Blogs = _context.Blogs.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            if (blog == null)
            {
                return HttpNotFound();
            }

            return View(blog);
        }

        
    }
}