using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Inventory.Forms
{
    [FormScript("Inventory.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductForm
    {
        public String Name { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int32 SupplierId { get; set; }
    }
}