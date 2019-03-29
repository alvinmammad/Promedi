using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Models
{
    public class Blog
    {
        [Required]
        public int ID { get; set; }
        [StringLength(maximumLength:45)]
        public string Title { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 250)]

        public string Photo { get; set; }
        [StringLength(maximumLength: 200)]
        public string Blockquote { get; set; }
        public DateTime Date { get; set; }
        public int Comment { get; set; }
        [StringLength(1000)]
        public string Slug { get; set; }
        public int CategoryID { get; set; }
        public int AuthorID { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
    }
}