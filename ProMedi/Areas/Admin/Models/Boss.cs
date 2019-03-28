using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Areas.Admin.Models
{
    public class Boss
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Fullname { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Password { get; set; }
    }
}