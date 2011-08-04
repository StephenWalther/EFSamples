using System.Web.Mvc;

namespace EFSamples.Areas.Sample6Transactions {
    public class Sample6TransactionsAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Sample6Transactions";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Sample6Transactions_default",
                "Sample6Transactions/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
