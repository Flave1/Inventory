using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Inventory.Columns
{
    [ColumnsScript("Inventory.OrderItems")]
    [BasedOnRow(typeof(Entities.OrderItemsRow), CheckNames = true)]
    public class OrderItemsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Hidden]
        public Int64 OrderItemId { get; set; }
        //public String OrderOrderDecription { get; set; }
        public DateTime OrderDate { get; set; }
        [EditLink]
        public String ItemName { get; set; }
        public Int32 Qty { get; set; }
        public Decimal UnitPrice { get; set; }
        public String ProductName { get; set; }
        public Decimal SubTotal { get; set; }
    }
}