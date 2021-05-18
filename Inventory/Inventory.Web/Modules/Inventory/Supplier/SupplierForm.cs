using Serenity.ComponentModel;
using System;
using Inventory.Web.Modules.Inventory.Enums;

namespace Inventory.Inventory.Forms
{
    [FormScript("Inventory.Supplier")]
    [BasedOnRow(typeof(Entities.SupplierRow), CheckNames = true)]
    public class SupplierForm
    {
        public Int32 UserId { get; set; }
        public String CompanyName { get; set; }
        public SupplierTypes SupplierType { get; set; }
    }
}