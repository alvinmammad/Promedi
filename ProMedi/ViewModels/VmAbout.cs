using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.DAL;
using ProMedi.Models;
namespace ProMedi.ViewModels
{
    public class VmAbout
    {
        public Setting Setting { get; set; }
        public About About{ get; set; }
        public AboutBody AboutBody { get; set; }
        public List<AboutFeature> AboutFeatures { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Fact> Facts { get; set; }
        public List<Card> Cards { get; set; }
    }
}