using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Models
{
    public class Department
    {
        [Required]
        public int ID { get; set; }

        public string EventHours { get; set; }
        [StringLength(maximumLength:30)]
        public string Name { get; set; }

        [StringLength(maximumLength: 40)]
        public string Title { get; set; }

        [StringLength(maximumLength: 200)]

        public string Desc { get; set; }
        [StringLength(maximumLength: 30)]

        public string EventType { get; set; }
        [StringLength(maximumLength: 50)]

        public string Address { get; set; }
        [StringLength(maximumLength: 30)]

        public string Email { get; set; }
        [StringLength(maximumLength: 20)]

        public string Phone { get; set; }
        [StringLength(maximumLength: 250)]

        public string Photo { get; set; }
        [StringLength(maximumLength: 250)]

        public string Icon { get; set; }

        public string HeadType { get; set; }

        public string HeadDoctor { get; set; }


        [StringLength(maximumLength:1000)]
        public string Slug { get; set; }

        public List<Appointment> Appointments { get; set; }

    }
}