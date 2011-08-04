using System.Web.Mvc;

namespace EFSamples.Areas.Sample8StoredProcedures {
    public class Sample8StoredProceduresAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample8StoredProcedures";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample8StoredProcedures_default",
                "Sample8StoredProcedures/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
