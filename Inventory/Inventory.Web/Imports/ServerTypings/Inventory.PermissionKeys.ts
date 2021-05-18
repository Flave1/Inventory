namespace Inventory.Inventory {
    declare namespace PermissionKeys {
        export const General = "Inventory:General";

        namespace Orders {
            export const Delete = "Inventory:Orders:Delete";
            export const Modify = "Inventory:Orders:Modify";
            export const View = "Inventory:Orders:View";
        }

        namespace Products {
            export const Delete = "Inventory:Products:Delete";
            export const Modify = "Inventory:Products:Modify";
            export const View = "Inventory:Products:View";
        }
    }
}
