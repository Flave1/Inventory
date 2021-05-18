using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Inventory.Pages
{

    [PageAuthorize(typeof(Entities.SupplierRow))]
    public class SupplierController : Controller
    {
        [Route("Inventory/Supplier")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/Supplier/SupplierIndex.cshtml");
        }
    }
}