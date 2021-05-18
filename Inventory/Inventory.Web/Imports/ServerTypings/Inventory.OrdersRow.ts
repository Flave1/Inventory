namespace Inventory.Inventory {
    export interface OrdersRow {
        OrderId?: number;
        CustomerId?: number;
        OrderDate?: string;
        Total?: number;
        OrderDecription?: string;
        CustomerUsername?: string;
        CustomerDisplayName?: string;
        CustomerEmail?: string;
        CustomerSource?: string;
        CustomerLastDirectoryUpdate?: string;
        CustomerUserImage?: string;
        CustomerInsertDate?: string;
        CustomerInsertUserId?: number;
        CustomerUpdateDate?: string;
        CustomerUpdateUserId?: number;
        CustomerIsActive?: number;
        CustomerUserType?: number;
        Status?: number;
        StatusName?: string;
        StatusFailedDescription?: string;
        OrderItems?: OrderItemsRow[];
    }

    export namespace OrdersRow {
        export const idProperty = 'OrderId';
        export const nameProperty = 'OrderDecription';
        export const localTextPrefix = 'Inventory.Orders';
        export const lookupKey = 'Inventory.Orders';

        export function getLookup(): Q.Lookup<OrdersRow> {
            return Q.getLookup<OrdersRow>('Inventory.Orders');
        }
        export const deletePermission = 'Inventory:Orders:Modify';
        export const insertPermission = 'Inventory:Orders:Modify';
        export const readPermission = 'Inventory:Orders:View';
        export const updatePermission = 'Inventory:Orders:Modify';

        export declare const enum Fields {
            OrderId = "OrderId",
            CustomerId = "CustomerId",
            OrderDate = "OrderDate",
            Total = "Total",
            OrderDecription = "OrderDecription",
            CustomerUsername = "CustomerUsername",
            CustomerDisplayName = "CustomerDisplayName",
            CustomerEmail = "CustomerEmail",
            CustomerSource = "CustomerSource",
            CustomerLastDirectoryUpdate = "CustomerLastDirectoryUpdate",
            CustomerUserImage = "CustomerUserImage",
            CustomerInsertDate = "CustomerInsertDate",
            CustomerInsertUserId = "CustomerInsertUserId",
            CustomerUpdateDate = "CustomerUpdateDate",
            CustomerUpdateUserId = "CustomerUpdateUserId",
            CustomerIsActive = "CustomerIsActive",
            CustomerUserType = "CustomerUserType",
            Status = "Status",
            StatusName = "StatusName",
            StatusFailedDescription = "StatusFailedDescription",
            OrderItems = "OrderItems"
        }
    }
}
