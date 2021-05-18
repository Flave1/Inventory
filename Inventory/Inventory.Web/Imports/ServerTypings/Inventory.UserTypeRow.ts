namespace Inventory.Inventory {
    export interface UserTypeRow {
        UserTypeId?: number;
        Name?: string;
    }

    export namespace UserTypeRow {
        export const idProperty = 'UserTypeId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Inventory.UserType';
        export const lookupKey = 'Inventory.UserType';

        export function getLookup(): Q.Lookup<UserTypeRow> {
            return Q.getLookup<UserTypeRow>('Inventory.UserType');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            UserTypeId = "UserTypeId",
            Name = "Name"
        }
    }
}
