namespace Inventory.Inventory {
    export interface OrderItemsRow {
        OrderItemId?: number;
        OrderId?: number;
        OrderDate?: string;
        ItemName?: string;
        Qty?: number;
        UnitPrice?: number;
        ProductId?: number;
        SubTotal?: number;
        OrderCustomerId?: number;
        OrderOrderDate?: string;
        OrderTotal?: number;
        OrderOrderDecription?: string;
        ProductName?: string;
        ProductSupplierId?: number;
    }

    export namespace OrderItemsRow {
        export const idProperty = 'OrderItemId';
        export const nameProperty = 'ItemName';
        export const localTextPrefix = 'Inventory.OrderItems';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderItemId = "OrderItemId",
            OrderId = "OrderId",
            OrderDate = "OrderDate",
            ItemName = "ItemName",
            Qty = "Qty",
            UnitPrice = "UnitPrice",
            ProductId = "ProductId",
            SubTotal = "SubTotal",
            OrderCustomerId = "OrderCustomerId",
            OrderOrderDate = "OrderOrderDate",
            OrderTotal = "OrderTotal",
            OrderOrderDecription = "OrderOrderDecription",
            ProductName = "ProductName",
            ProductSupplierId = "ProductSupplierId"
        }
    }
}
