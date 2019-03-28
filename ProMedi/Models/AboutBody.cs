using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.DAL;
using ProMedi.Models;
namespace ProMedi.Models
{
    public class AboutBody
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}