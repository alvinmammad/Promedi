using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Models
{
    public class Doctor
    {
        [Required]
        public int ID { get; set; }
        [StringLength(maximumLength:35)]
        public string Name { get; set; }
        [StringLength(maximumLength: 150)]

        public string Desc { get; set; }
        [StringLength(maximumLength: 250)]

        public string Photo { get; set; }
        [StringLength(maximumLength: 70)]

        public string Info { get; set; }
        [StringLength(maximumLength: 35)]

        public string Address { get; set; }
        [StringLength(maximumLength: 20)]

        public string Phone { get; set; }
        [StringLength(maximumLength: 25)]

        public string Email { get; set; }
        [StringLength(maximumLength: 35)]

        public string Speciality { get; set; }
        [StringLength(maximumLength: 35)]

        public string Degree { get; set; }
        [StringLength(maximumLength: 40)]

        public string ExpertIn { get; set; }

        [StringLength(1000)]
        public string Slug { get; set; }
        public int CategoryID { get; set; }
        public DoctorCategory Category { get; set; }
        public List<Appointment> Appointments { get; set; }
       



    }
}