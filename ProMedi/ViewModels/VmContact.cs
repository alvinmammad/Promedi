using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.DAL;
using ProMedi.Models;

namespace ProMedi.ViewModels
{
    public class VmContact
    {
        public List<Contact> Contacts { get; set; }
        public Setting Setting { get; set; }
    }
}