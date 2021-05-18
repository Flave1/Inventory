using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Inventory.Pages
{

    [PageAuthorize(typeof(Entities.OrderItemsRow))]
    public class OrderItemsController : Controller
    {
        [Route("Inventory/OrderItems")]
        public ActionResult Index()
        { 
            return View("~/Modules/Inventory/OrderItems/OrderItemsIndex.cshtml");
        }
    }
}