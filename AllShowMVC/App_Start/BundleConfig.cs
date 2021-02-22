using System.Web;
using System.Web.Optimization;

namespace AllShowMVC
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/node_modules/jquery/dist/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/node_modules/jquery-validation/dist/jquery.validate.js",
                        "~/Scripts/node_modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/node_modules/bootstrap/dist/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                      "~/Scripts/node_modules/vue/dist/vue.js",
                      "~/Scripts/node_modules/bootstrap-vue/dist/bootstrap-vue.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/axios").Include(
                      "~/Scripts/node_modules/axios/dist/axios.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/node_modules/bootstrap/dist/css/bootstrap.css",
                      "~/Scripts/node_modules/bootstrap-vue/dist/bootstrap-vue.min.css",
                      "~/Content/site.css"));
        }
    }
}
