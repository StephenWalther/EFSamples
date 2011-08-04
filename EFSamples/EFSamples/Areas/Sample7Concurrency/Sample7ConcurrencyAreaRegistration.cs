using System.Web.Mvc;

namespace EFSamples.Areas.Sample7Concurrency {
    public class Sample7ConcurrencyAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample7Concurrency";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample7Concurrency_default",
                "Sample7Concurrency/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
