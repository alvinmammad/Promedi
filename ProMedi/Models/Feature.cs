using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProMedi.Models
{
    public class Feature
    {
        public int ID { get; set; }
        [StringLength(maximumLength: 250)]

        public string Logo { get; set; }
        [StringLength(maximumLength: 25)]

        public string Name { get; set; }
        [StringLength(maximumLength: 55)]

        public string Title { get; set; }
    }
}