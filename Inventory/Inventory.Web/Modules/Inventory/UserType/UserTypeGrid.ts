
namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class UserTypeGrid extends Serenity.EntityGrid<UserTypeRow, any> {
        protected getColumnsKey() { return 'Inventory.UserType'; }
        protected getDialogType() { return UserTypeDialog; }
        protected getIdProperty() { return UserTypeRow.idProperty; }
        protected getInsertPermission() { return UserTypeRow.insertPermission; }
        protected getLocalTextPrefix() { return UserTypeRow.localTextPrefix; }
        protected getService() { return UserTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}