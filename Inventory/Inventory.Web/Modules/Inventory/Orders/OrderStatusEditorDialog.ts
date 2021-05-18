/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class OrderStatusEditorDialog extends
        Common.GridEditorDialog<OrdersRow> {
        protected getFormKey() { return OrderStatusUpdateForm.formKey; }
        protected getNameProperty() { return OrderItemsRow.nameProperty; }
        protected getLocalTextPrefix() { return OrderItemsRow.localTextPrefix; }

        protected form: OrderStatusUpdateForm;

        constructor() {
            super();
            this.form = new OrderStatusUpdateForm(this.idPrefix);
        }
    }
}