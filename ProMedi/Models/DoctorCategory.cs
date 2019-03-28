using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProMedi.Models
{
    public class DoctorCategory
    {
        public int ID { get; set; }
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}