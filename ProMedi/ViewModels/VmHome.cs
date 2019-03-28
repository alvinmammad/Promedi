using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.Models;
namespace ProMedi.ViewModels
{
    public class VmHome
    {
        public List<Doctor> Doctors { get; set; }
        public List<Department> Departments { get; set; }
        public List<Fact> Facts { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<HomeCard> HomeCards { get; set; }
        public HomeExperience HomeExperience { get; set; }
        public About About { get; set; }
        public Contact Contact { get; set; }
        public Setting Setting { get; set; }


    }
}