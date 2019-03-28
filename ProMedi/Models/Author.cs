using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace ProMedi.Models
{
    public class Author
    {
        public int ID { get; set; }
        [StringLength(maximumLength:20)]
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
        [StringLength(maximumLength: 250)]

        public string Photo { get; set; }
    }
}