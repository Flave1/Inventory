using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Inventory.Forms
{
    [FormScript("Inventory.OrderItems")]
    [BasedOnRow(typeof(Entities.OrderItemsRow))]
    public class OrderItemsForm
    {
        //public Int64 OrderId { get; set; }
        //public DateTime OrderDate { get; set; }
        public Int64 ProductId { get; set; }
        public Int32 Qty { get; set; }
        public Decimal UnitPrice { get; set; }
        public String ItemName { get; set; }
        //public Decimal SubTotal { get; set; }
    }
}