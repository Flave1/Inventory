using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Inventory.Pages
{

    [PageAuthorize(typeof(Entities.ProductRow))]
    public class ProductController : Controller
    {
        [Route("Inventory/Product")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/Product/ProductIndex.cshtml");
        }
    }
}