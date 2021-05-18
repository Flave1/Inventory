
namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class FulfillmentStatusGrid extends Serenity.EntityGrid<FulfillmentStatusRow, any> {
        protected getColumnsKey() { return 'Inventory.FulfillmentStatus'; }
        protected getDialogType() { return FulfillmentStatusDialog; }
        protected getIdProperty() { return FulfillmentStatusRow.idProperty; }
        protected getInsertPermission() { return FulfillmentStatusRow.insertPermission; }
        protected getLocalTextPrefix() { return FulfillmentStatusRow.localTextPrefix; }
        protected getService() { return FulfillmentStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}