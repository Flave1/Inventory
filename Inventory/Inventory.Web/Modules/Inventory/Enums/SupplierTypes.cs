using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Web.Modules.Inventory.Enums
{
    public enum SupplierTypes
    {
        [Description("Computers and accessories")]
        Accessories = 1,
        [Description("Cotton materials")]
        Materials = 2,
        [Description("Food")]
        Food = 3,
    }
}
