using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProMedi.Models
{
    //public enum Dayoftheweek
    //{
    //    Monday=1,
    //    Sunday=2
    //}
    public class Contact
    {
        [Required]
        public int ID { get; set; }
        [StringLength(maximumLength:30)]
        public string Email { get; set; }
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        //[Column(TypeName ="tinyint")]
        //public Dayoftheweek Day { get; set; }
        
    }
}