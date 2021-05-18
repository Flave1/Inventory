using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Inventory.Pages
{

    [PageAuthorize(typeof(Entities.FulfillmentStatusRow))]
    public class FulfillmentStatusController : Controller
    {
        [Route("Inventory/FulfillmentStatus")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/FulfillmentStatus/FulfillmentStatusIndex.cshtml");
        }
    }
}