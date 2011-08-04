using System.Web.Mvc;

namespace EFSamples.Areas.Sample1ComplexObjects {
    public class Sample1ComplexObjectsAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample1ComplexObjects";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample1ComplexObjects_default",
                "Sample1ComplexObjects/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
