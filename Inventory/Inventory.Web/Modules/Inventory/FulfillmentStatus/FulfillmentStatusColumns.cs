using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Inventory.Columns
{
    [ColumnsScript("Inventory.FulfillmentStatus")]
    [BasedOnRow(typeof(Entities.FulfillmentStatusRow), CheckNames = true)]
    public class FulfillmentStatusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 StatusId { get; set; }
        [EditLink]
        public String StatusName { get; set; }
    }
}