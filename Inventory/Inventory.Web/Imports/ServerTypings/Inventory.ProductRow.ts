namespace Inventory.Inventory {
    export interface ProductRow {
        ProductId?: number;
        Name?: string;
        SupplierId?: number;
        UnitPrice?: number;
        SupplierUserId?: number;
        SupplierCompanyName?: string;
        SupplierSupplierType?: number;
    }

    export namespace ProductRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Inventory.Product';
        export const lookupKey = 'Inventory.Product';

        export function getLookup(): Q.Lookup<ProductRow> {
            return Q.getLookup<ProductRow>('Inventory.Product');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProductId = "ProductId",
            Name = "Name",
            SupplierId = "SupplierId",
            UnitPrice = "UnitPrice",
            SupplierUserId = "SupplierUserId",
            SupplierCompanyName = "SupplierCompanyName",
            SupplierSupplierType = "SupplierSupplierType"
        }
    }
}
