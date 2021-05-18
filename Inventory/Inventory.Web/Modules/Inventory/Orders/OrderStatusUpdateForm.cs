using Inventory.Inventory.Entities;
using Serenity.ComponentModel;
using System;

namespace Inventory.Inventory.Forms
{
    //[FormScript("Inventory.Orders")]
    //[BasedOnRow(typeof(OrdersRow), CheckNames = true)]
    public class OrderStatusUpdateForm
    { 
        public Int32 Status { get; set; }  
    }
}
