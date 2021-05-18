
namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class OrderItemsDialog extends Serenity.EntityDialog<OrderItemsRow, any> {
        protected getFormKey() { return OrderItemsForm.formKey; }
        protected getIdProperty() { return OrderItemsRow.idProperty; }
        protected getLocalTextPrefix() { return OrderItemsRow.localTextPrefix; }
        protected getNameProperty() { return OrderItemsRow.nameProperty; }
        protected getService() { return OrderItemsService.baseUrl; }
        protected getDeletePermission() { return OrderItemsRow.deletePermission; }
        protected getInsertPermission() { return OrderItemsRow.insertPermission; }
        protected getUpdatePermission() { return OrderItemsRow.updatePermission; }

        protected form = new OrderItemsForm(this.idPrefix);

    }
}