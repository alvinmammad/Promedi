using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProMedi.Models
{
    public class HomeExperience
    {
        public int ID { get; set; }
        [StringLength(maximumLength: 150)]

        public string Desc { get; set; }
    }
}