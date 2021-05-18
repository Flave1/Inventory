using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using Inventory.Inventory.Entities;

namespace Inventory.Inventory.Forms
{
    [FormScript("Inventory.Orders")]
    [BasedOnRow(typeof(OrdersRow), CheckNames = true)]
    public class OrdersForm
    {
        public Int32 CustomerId { get; set; } 
        public String OrderDecription { get; set; }
        [OrderItemEditor]
        public List<OrderItemsRow> OrderItems { get; set; }
    }
}