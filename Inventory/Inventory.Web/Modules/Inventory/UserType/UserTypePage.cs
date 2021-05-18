using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Inventory.Pages
{

    [PageAuthorize(typeof(Entities.UserTypeRow))]
    public class UserTypeController : Controller
    {
        [Route("Inventory/UserType")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/UserType/UserTypeIndex.cshtml");
        }
    }
}