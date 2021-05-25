using System.Web;
using System.Web.Optimization;

namespace SeSandoval
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*
             * Scripts
             */
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/Lib/mdc").Include(
            //            "~/Lib/MDC/material-components-web.js"));

            bundles.Add(new ScriptBundle("~/Lib/vuejs").Include(
                        "~/Lib/Vuejs/vue.js"));

            bundles.Add(new ScriptBundle("~/Lib/vuetifyjs").Include(
                        "~/Lib/Vuetify/vuetify.js"));

            bundles.Add(new ScriptBundle("~/bundles/shared").Include(
                        "~/Scripts/Shared/main.js"));

            /*
             * Style
             */
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/SeSandovalStyle.css"));

            //bundles.Add(new StyleBundle("~/Lib/mdc").Include(
            //          "~/Lib/MDC/material-components-web.css"));

            bundles.Add(new StyleBundle("~/Lib/vuetifycss").Include(
                      "~/Lib/Vuetify/vuetify.css"));
        }
    }
}
