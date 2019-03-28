using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Models
{
    public class Tag
    {
        public int ID { get; set; }
        [StringLength(maximumLength: 35)]

        public string Name { get; set; }
    }
}