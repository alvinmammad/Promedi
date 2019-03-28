using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProMedi.Models
{
    public class Fact
    {
        public int ID { get; set; }
        public int OrderBy { get; set; }
        public int Value { get; set; }
        [StringLength(maximumLength: 20)]

        public string Key { get; set; }
        [StringLength(maximumLength: 200)]

        public string Icon { get; set; }
    }
}