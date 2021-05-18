
namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class FulfillmentStatusDialog extends Serenity.EntityDialog<FulfillmentStatusRow, any> {
        protected getFormKey() { return FulfillmentStatusForm.formKey; }
        protected getIdProperty() { return FulfillmentStatusRow.idProperty; }
        protected getLocalTextPrefix() { return FulfillmentStatusRow.localTextPrefix; }
        protected getNameProperty() { return FulfillmentStatusRow.nameProperty; }
        protected getService() { return FulfillmentStatusService.baseUrl; }
        protected getDeletePermission() { return FulfillmentStatusRow.deletePermission; }
        protected getInsertPermission() { return FulfillmentStatusRow.insertPermission; }
        protected getUpdatePermission() { return FulfillmentStatusRow.updatePermission; }

        protected form = new FulfillmentStatusForm(this.idPrefix);

    }
}