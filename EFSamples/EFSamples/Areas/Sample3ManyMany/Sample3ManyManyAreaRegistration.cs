using System.Web.Mvc;

namespace EFSamples.Areas.Sample3ManyMany {
    public class Sample3ManyManyAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample3ManyMany";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample3ManyMany_default",
                "Sample3ManyMany/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
