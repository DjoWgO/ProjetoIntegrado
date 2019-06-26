using System.Web;
using System.Web.Optimization;

namespace PPC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.mask.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                        "~/Scripts/vue.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
                      "~/Scripts/toastr.js"));

            bundles.Add(new StyleBundle("~/Content/toastr").Include(
                    "~/Content/toastr.css"));

            bundles.Add(new ScriptBundle("~/bundles/select2").Include(
                     "~/Scripts/select2.js"));

            bundles.Add(new StyleBundle("~/Content/select2").Include(
                    "~/Content/select2.css",
                    "~/Content/select2-bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                     "~/Scripts/jquery.dataTables.min.js",
                     "~/Scripts/dataTables.bootstrap.js"
                     ));
            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                   "~/Content/datatables.css"));


            BundleTable.EnableOptimizations = false;
        }
    }
}
