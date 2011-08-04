using System.Web.Mvc;

namespace EFSamples.Areas.Sample5Inheritance {
    public class Sample5InheritanceAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample5Inheritance";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample5Inheritance_default",
                "Sample5Inheritance/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
