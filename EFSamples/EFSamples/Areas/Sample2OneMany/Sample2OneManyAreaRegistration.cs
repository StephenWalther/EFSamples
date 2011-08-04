using System.Web.Mvc;

namespace EFSamples.Areas.Sample2OneMany {
    public class Sample2OneManyAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample2OneMany";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample2OneMany_default",
                "Sample2OneMany/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
