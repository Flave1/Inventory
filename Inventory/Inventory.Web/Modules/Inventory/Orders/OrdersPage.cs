using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Inventory.Pages
{

    [PageAuthorize(typeof(Entities.OrdersRow))]
    public class OrdersController : Controller
    {
        [Route("Inventory/Orders")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/Orders/OrdersIndex.cshtml");
        }
    }
}