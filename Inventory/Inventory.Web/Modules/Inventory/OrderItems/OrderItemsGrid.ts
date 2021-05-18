
namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class OrderItemsGrid extends Serenity.EntityGrid<OrderItemsRow, any> {
        protected getColumnsKey() { return 'Inventory.OrderItems'; }
        protected getDialogType() { return OrderItemsDialog; }
        protected getIdProperty() { return OrderItemsRow.idProperty; }
        protected getInsertPermission() { return OrderItemsRow.insertPermission; }
        protected getLocalTextPrefix() { return OrderItemsRow.localTextPrefix; }
        protected getService() { return OrderItemsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

    }
}