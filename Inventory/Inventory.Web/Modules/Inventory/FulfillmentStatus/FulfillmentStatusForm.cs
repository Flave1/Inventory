using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Inventory.Forms
{
    [FormScript("Inventory.FulfillmentStatus")]
    [BasedOnRow(typeof(Entities.FulfillmentStatusRow), CheckNames = true)]
    public class FulfillmentStatusForm
    {
        public String StatusName { get; set; }
    }
}