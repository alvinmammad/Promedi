using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Models
{
    public class About
    {
        [Required]
        public int ID { get; set; }
        [StringLength(maximumLength:20)]
        public string Title { get; set; }
        [StringLength(maximumLength: 150)]
        public string Desc { get; set; }
        [StringLength(maximumLength:250)]
        public string Photo { get; set; }

    }
}