using System.Web;
using System.Web.Optimization;

namespace ArtWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Assets/Scripts/jquery.{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Assets/Scripts/jquery.min.js",//ok
                "~/Assets/Scripts/jquery.cslider.js",//ok
                "~/Assets/Scripts/jquery.smint.js"//nav
                , "~/Assets/Scripts/jquery.wmuSlider.js"//ok
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Assets/Scripts/jquery.validate*",
                "~/Assets/Scripts/jquery.unobtrusive-ajax.min.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            /*bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js")); */

            bundles.Add(new StyleBundle("~/assets/bundles/css").Include(
                      "~/Assets/Css/slider.css"
                      ,"~/Assets/Css/style.css"
                      ));

            bundles.Add(new StyleBundle("~/bundles/js").Include(
                "~/Assets/Scripts/modernizr.custom.28468.js",//ok
                "~/Assets/Scripts/responsive.menu.js",//nav
                "~/Assets/Scripts/move-top.js",//ok
                "~/Assets/Scripts/easing.js"//ok
                ));

            //bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/Assets/Css", "*.css"));
        }
    }
}
