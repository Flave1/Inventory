namespace Inventory.Inventory {
    export interface FulfillmentStatusRow {
        StatusId?: number;
        StatusName?: string;
    }

    export namespace FulfillmentStatusRow {
        export const idProperty = 'StatusId';
        export const nameProperty = 'StatusName';
        export const localTextPrefix = 'Inventory.FulfillmentStatus';
        export const lookupKey = 'Inventory.FulfillmentStatus';

        export function getLookup(): Q.Lookup<FulfillmentStatusRow> {
            return Q.getLookup<FulfillmentStatusRow>('Inventory.FulfillmentStatus');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            StatusId = "StatusId",
            StatusName = "StatusName"
        }
    }
}
