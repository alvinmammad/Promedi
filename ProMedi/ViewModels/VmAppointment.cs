using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.Models;
using ProMedi.DAL;

namespace ProMedi.ViewModels
{
    public class VmAppointment
    {
        public Setting Setting { get; set; }
        public List<Department> Departments { get; set; }
        public List<Doctor> Doctors { get; set; }

    }
}