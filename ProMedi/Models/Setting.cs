using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Models
{
    public class Setting
    {
        public int ID { get; set; }
        [StringLength(maximumLength: 20)]

        public string Phone { get; set; }
        [StringLength(maximumLength: 35)]

        public string Location { get; set; }

       
    }
}