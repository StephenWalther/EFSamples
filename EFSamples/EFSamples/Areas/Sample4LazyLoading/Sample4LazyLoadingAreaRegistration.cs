using System.Web.Mvc;

namespace EFSamples.Areas.Sample4LazyLoading {
    public class Sample4LazyLoadingAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample4LazyLoading";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample4LazyLoading_default",
                "Sample4LazyLoading/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
