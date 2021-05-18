namespace Inventory.Inventory {
    export interface SupplierRow {
        SupplierId?: number;
        UserId?: number;
        CompanyName?: string;
        SupplierType?: Web.Modules.Inventory.Enums.SupplierTypes;
        UserUsername?: string;
        UserDisplayName?: string;
        UserEmail?: string;
        UserSource?: string;
        UserLastDirectoryUpdate?: string;
        UserUserImage?: string;
        UserInsertDate?: string;
        UserInsertUserId?: number;
        UserUpdateDate?: string;
        UserUpdateUserId?: number;
        UserIsActive?: number;
        UserUserType?: number;
    }

    export namespace SupplierRow {
        export const idProperty = 'SupplierId';
        export const nameProperty = 'CompanyName';
        export const localTextPrefix = 'Inventory.Supplier';
        export const lookupKey = 'Inventory.Suppliers';

        export function getLookup(): Q.Lookup<SupplierRow> {
            return Q.getLookup<SupplierRow>('Inventory.Suppliers');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            SupplierId = "SupplierId",
            UserId = "UserId",
            CompanyName = "CompanyName",
            SupplierType = "SupplierType",
            UserUsername = "UserUsername",
            UserDisplayName = "UserDisplayName",
            UserEmail = "UserEmail",
            UserSource = "UserSource",
            UserLastDirectoryUpdate = "UserLastDirectoryUpdate",
            UserUserImage = "UserUserImage",
            UserInsertDate = "UserInsertDate",
            UserInsertUserId = "UserInsertUserId",
            UserUpdateDate = "UserUpdateDate",
            UserUpdateUserId = "UserUpdateUserId",
            UserIsActive = "UserIsActive",
            UserUserType = "UserUserType"
        }
    }
}
