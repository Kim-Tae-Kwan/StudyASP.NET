using System.Web;
using System.Web.Optimization;

namespace EddyNewHome
{
    public class BundleConfig
    {
        // 묶음에 대한 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=301862를 참조하세요.
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 원본 스크립트 및 CSS
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #endregion

            #region Samual Anderson Template style 스크립트 및 CSS
            //CSS
            bundles.Add(new StyleBundle("~/eddyhome/css").Include(
                "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                "~/assets/vendor/fontawesome/css/font-awesome.min.css",
                "~/assets/vendor/flaticons/flaticon.css",
                "~/assets/vendor/hover/css/hover-min.css",
                "~/assets/vendor/wow/animate.css",
                "~/assets/vendor/mfp/css/magnific-popup.css",
                "~/assets/vendor/footable/footable.core.css", //200813 페이저 영역 추가
                "~/assets/custom/css/style.css"));
            //Javascript
            bundles.Add(new ScriptBundle("~/eddyhome/js").Include(
                 "~/assets/vendor/jquery/js/jquery-2.2.0.min.js",
                "~/assets/vendor/bootstrap/js/bootstrap.min.js",
                "~/assets/vendor/imagesloaded/js/imagesloaded.pkgd.min.js",
                "~/assets/vendor/isotope/js/isotope.pkgd.min.js",
                "~/assets/vendor/mfp/js/jquery.magnific-popup.min.js",
                "~/assets/vendor/circle-progress/circle-progress.js",
                "~/assets/vendor/waypoints/waypoints.min.js",
                "~/assets/vendor/anicounter/jquery.counterup.min.js",
                "~/assets/vendor/wow/wow.min.js",
                "~/assets/vendor/pjax/jquery.pjax.js",
                "~/assets/vendor/footable/footable.all.min.js", //200813 신규추가
                "~/assets/custom/js/custom.js"
                ));

            #endregion

            #region Dash.io Admin용 템플릿

            bundles.Add(new StyleBundle("~/dashio/css").Include(
                "~/Dashio/lib/bootstrap/css/bootstrap.min.css",
                "~/Dashio/lib/font-awesome/css/font-awesome.css",
                "~/Dashio/css/zabuto_calendar.css",
                "~/Dashio/lib/gritter/css/jquery.gritter.css",
                "~/assets/vendor/footable/footable.core.css", //200818 
                "~/Dashio/css/style.css",
                "~/Dashio/css/style-responsive.css"
                ));

            bundles.Add(new ScriptBundle("~/dashio/header_js").Include(
                "~/Dashio/lib/chart-master/Chart.js"
                ));

            bundles.Add(new ScriptBundle("~/dashio/footer_js").Include(
                "~/Dashio/lib/jquery/jquery.min.js",
                "~/Dashio/lib/bootstrap/js/bootstrap.min.js",
                "~/Dashio/lib/jquery.dcjqaccordion.2.7.js",
                "~/Dashio/lib/jquery.scrollTo.min.js",
                "~/Dashio/lib/jquery.nicescroll.js",
                "~/Dashio/lib/jquery.sparkline.js",
                "~/Dashio/lib/common-scripts.js",
                "~/Dashio/lib/gritter/js/jquery.gritter.js",
                "~/Dashio/lib/gritter-conf.js",
                "~/Dashio/lib/sparkline-chart.js",
                "~/assets/vendor/footable/footable.all.min.js", //200818
                "~/Dashio/lib/zabuto_calendar.js"
                ));

            #endregion
        }
    }
}
