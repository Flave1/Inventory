
using Serenity.ComponentModel;
using System.ComponentModel;

namespace Inventory.Inventory
{
    [NestedPermissionKeys]
    [DisplayName("Inventory")]
    public class PermissionKeys
    {
        [DisplayName("Orders")]
        public class Orders
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Inventory:Orders:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Inventory:Orders:Modify";
            public const string View = "Inventory:Orders:View";
        }

        [DisplayName("Products")]
        public class Products
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Inventory:Products:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Inventory:Products:Modify";
            public const string View = "Inventory:Products:View";
        }

        [Description("[General]")]
        public const string General = "Inventory:General";
    }
}
