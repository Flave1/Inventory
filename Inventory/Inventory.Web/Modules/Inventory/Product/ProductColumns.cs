using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Inventory.Columns
{
    [ColumnsScript("Inventory.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 ProductId { get; set; }
        [EditLink]
        public String Name { get; set; }
        public Decimal UnitPrice { get; set; }
        public String SupplierCompanyName { get; set; }

    }
}