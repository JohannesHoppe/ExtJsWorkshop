using System.Web;
using System.Web.Optimization;

namespace HelloWorld
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/myscript")
                .Include("~/Scripts/*.js"));

            bundles.Add(new StyleBundle("~/bundles/mystyles")
                .Include("~/Content/*.css"));
        }

    }
}