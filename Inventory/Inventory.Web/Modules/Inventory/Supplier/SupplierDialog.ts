
namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class SupplierDialog extends Serenity.EntityDialog<SupplierRow, any> {
        protected getFormKey() { return SupplierForm.formKey; }
        protected getIdProperty() { return SupplierRow.idProperty; }
        protected getLocalTextPrefix() { return SupplierRow.localTextPrefix; }
        protected getNameProperty() { return SupplierRow.nameProperty; }
        protected getService() { return SupplierService.baseUrl; }
        protected getDeletePermission() { return SupplierRow.deletePermission; }
        protected getInsertPermission() { return SupplierRow.insertPermission; }
        protected getUpdatePermission() { return SupplierRow.updatePermission; }

        protected form = new SupplierForm(this.idPrefix);

    }
}