using System.Web;
using System.Web.Optimization;

namespace RosieCastro
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/resume-theme").Include(
                "~/Scripts/resume-theme/bootstrap/bootstrap.min.js",
                "~/Scripts/resume-theme/fancybox/jquery.fancybox.pack.js",
                "~/Scripts/resume-theme/jquery-isotope/jquery.isotope.min.js",
                "~/Scripts/resume-theme/jquery-mate/jquery.mate-hover.1-0-min.js",
                "~/Scripts/resume-theme/PIE/PIE.js",
                "~/Scripts/resume-theme/jquery-1.9.1.min.js.js",
                "~/Scripts/resume-theme/script.js"
                ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.min.css",
            //          "~/Content/style.css", "~/Content/bootstrap-responsive.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                "~/Scripts/custom.js"
                ));

            bundles.Add(new StyleBundle("~/Content/resume-theme").Include(
                "~/Content/resume-theme/animations/animate.css",
                "~/Content/resume-theme/bootstrap/bootstrap-reponsive.min.css",
                "~/Content/resume-theme/bootstrap/bootstrap.min.css",
                "~/Content/resume-theme/color/blue.css",
                "~/Content/resume-theme/fancybox/blank.gif",
                "~/Content/resume-theme/fancybox/fancybox-close.png",
                "~/Content/resume-theme/fancybox/fancybox_loading.gif",
                "~/Content/resume-theme/fancybox/fancybox_overlay.png",
                "~/Content/resume-theme/fancybox/fancybox_sprite.png",
                "~/Content/resume-theme/fancybox/jquery.fancybox.css",
                "~/Content/resume-theme/jquery-mate/mate.hover.css",
                "~/Content/resume-theme/style.css",
                "~/Content/resume-theme/fonts/animation.css",
                "~/Content/resume-theme/fonts/fontello-codes.css",
                "~/Content/resume-theme/fonts/fontello-embedded.css",
                "~/Content/resume-theme/fonts/fontello-ie7-codes.css",
                "~/Content/resume-theme/fonts/fontello-ie7.css",
                "~/Content/resume-theme/fonts/fontello.css"
                ));


        }
    }
}
