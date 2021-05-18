using System.ComponentModel;

namespace Inventory.Web.Modules.Inventory.Enums
{

    //[LookupScript("Inventory.OrderStatus")]
    public enum FulfillmentStatusEnum
    {
        [Description("Pending")]
        Pending = 1,
        [Description("Complete")]
        Complete = 2,
        [Description("Failed")]
        Failed = 3
    }
}
