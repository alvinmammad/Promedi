using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.Models;

namespace ProMedi.ViewModels
{
    public class VmBlog
    {
        public List<Blog> Blogs { get; set; }

        public List<Category> Categories { get; set; }

        public int TotalPage { get; set; }

        public int ActivePage { get; set; }

        public int? Category { get; set; }

       
    }
}