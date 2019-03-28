using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.DAL;
using ProMedi.Models;
namespace ProMedi.ViewModels
{
    public class VmDepartment
    {
        public Department Department { get; set; }
        public Setting Setting { get; set; }
        public Contact Contact { get; set; }

    }
}