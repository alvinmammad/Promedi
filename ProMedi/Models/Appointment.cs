using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProMedi.Models
{
    public class Appointment
    {
        [Required]
        public int ID { get; set; }
        [StringLength(maximumLength:20)]
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int DoctorID { get; set; }
        public int DepartmentID { get; set; }
        public Doctor Doctor { get; set; }
        public Department Department { get; set; }
    }
}