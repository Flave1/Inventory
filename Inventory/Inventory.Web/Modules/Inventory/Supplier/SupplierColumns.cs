using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Inventory.Columns
{
    [ColumnsScript("Inventory.Supplier")]
    [BasedOnRow(typeof(Entities.SupplierRow), CheckNames = true)]
    public class SupplierColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 SupplierId { get; set; }
        public String UserUsername { get; set; }
        [EditLink]
        public String CompanyName { get; set; }
        public Int32 SupplierType { get; set; }
    }
}