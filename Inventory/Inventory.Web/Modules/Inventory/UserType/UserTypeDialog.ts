namespace Inventory.Inventory{

    @Serenity.Decorators.registerClass()
    export class UserTypeDialog extends Serenity.EntityDialog<UserTypeRow, any> {
        protected getFormKey() { return UserTypeForm.formKey; }
        protected getIdProperty() { return UserTypeRow.idProperty; }
        protected getLocalTextPrefix() { return UserTypeRow.localTextPrefix; }
        protected getNameProperty() { return UserTypeRow.nameProperty; }
        protected getService() { return UserTypeService.baseUrl; }
        protected getDeletePermission() { return UserTypeRow.deletePermission; }
        protected getInsertPermission() { return UserTypeRow.insertPermission; }
        protected getUpdatePermission() { return UserTypeRow.updatePermission; }

        protected form = new UserTypeForm(this.idPrefix);

    }
}