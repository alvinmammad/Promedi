using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMedi.DAL;
using ProMedi.Models;


namespace ProMedi.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Icon { get; set; }
    }
}