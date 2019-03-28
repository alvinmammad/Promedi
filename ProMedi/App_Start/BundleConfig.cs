using System.Web;
using System.Web.Optimization;

namespace ProMedi
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/assets/css/bootstrap.min.css",
                       "~/Content/assets/css/icofont-1.0.1.min.css",
                       "~/Content/assets/css/owl.carousel.min.css",
                       "~/Content/assets/css/owl.theme.default.min.css",
                       "~/Content/assets/css/animate.min.css",
                       "~/Content/assets/css/magnific-popup.css",
                       "~/Content/assets/css/jquery.ui.css",
                       "~/Content/assets/css/style.css",
                       "~/Content/assets/css/responsive.css"
                       ));
            #endregion

            #region js
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
               "~/Content/assets/js/jquery-2.2.4.min.js",
               "~/Content/assets/js/popper.min.js",
               "~/Content/assets/js/bootstrap-4.2.1.min.js",
               "~/Content/assets/js/owl.carousel.min.js",
               "~/Content/assets/js/jquery.magnific-popup.min.js",
               "~/Content/assets/js/waypoints.min.js",
               "~/Content/assets/js/jquery.counterup.min.js",
               "~/Content/assets/js/jquery-ui-1.12.1.min.js",
               "~/Content/assets/js/jquery.ajaxchimp.min.js",
               "~/Content/assets/js/form-validator.min.js",
               "~/Content/assets/js/contact-form-script.js",
               "~/Content/assets/js/promedi-map.js",
               "~/Content/assets/js/script.js"


               ));

           
            #endregion

            BundleTable.EnableOptimizations = true;
        }
    }
}
