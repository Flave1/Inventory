using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Inventory.Inventory.Columns
{
    [ColumnsScript("Inventory.Orders")]
    [BasedOnRow(typeof(Entities.OrdersRow), CheckNames = true)]
    public class OrdersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 OrderId { get; set; }
        public String CustomerUsername { get; set; }
        public DateTime OrderDate { get; set; }
        public Decimal Total { get; set; }
        [EditLink]
        [OrderItemEditor]
        public String OrderDecription { get; set; } 
        [EditLink(ItemType = "Inventory.FulfillmentStatus"), Width(200), QuickFilter, QuickFilterOption("multiple", true)]
        public String StatusName { get; set; }
        [Width(200)]
       // [Hidden]
        public String StatusFailedDescription { get; set; }
    }
}