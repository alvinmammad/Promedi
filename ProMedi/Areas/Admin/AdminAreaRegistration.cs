using System.Web.Mvc;

namespace ProMedi.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Login", action="Index" , Area="admin", id = UrlParameter.Optional },
                new[] { "ProMedi.Areas.Admin.Controllers" }
            );



        }
    }
}