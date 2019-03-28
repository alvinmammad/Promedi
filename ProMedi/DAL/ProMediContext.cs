using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProMedi.Models;
using ProMedi.Areas.Admin.Models;

namespace ProMedi.DAL
{
    public class ProMediContext:DbContext
    {
        public ProMediContext():base("PromediContext")    
        {
        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorCategory> DoctorCategories { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<HomeCard> HomeCards { get; set; }
        public DbSet<HomeExperience> HomeExperiences { get; set; }
        public DbSet<AboutBody> AboutBodies { get; set; }
        public DbSet<AboutFeature> AboutFeatures { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Boss> Bosses { get; set; }
    }
}