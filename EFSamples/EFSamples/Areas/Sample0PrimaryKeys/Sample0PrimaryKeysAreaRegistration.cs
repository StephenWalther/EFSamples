using System.Web.Mvc;

namespace EFSamples.Areas.Sample0PrimaryKeys {
    public class Sample0PrimaryKeysAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample0PrimaryKeys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample0PrimaryKeys_default",
                "Sample0PrimaryKeys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
