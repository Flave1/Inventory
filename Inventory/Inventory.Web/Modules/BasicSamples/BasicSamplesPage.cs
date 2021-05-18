using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Inventory.BasicSamples.Pages
{
    [PageAuthorize, Route("BasicSamples/[action]")]
    public partial class BasicSamplesController : Controller
    {
    }
}
