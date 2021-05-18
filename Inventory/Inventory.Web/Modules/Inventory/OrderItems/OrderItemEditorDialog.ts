/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Inventory.Inventory {

    @Serenity.Decorators.registerClass()
    export class OrderItemEditorDialog extends
        Common.GridEditorDialog<OrderItemsRow> {
        protected getFormKey() { return OrderItemsForm.formKey; }
        protected getNameProperty() { return OrderItemsRow.nameProperty; }
        protected getLocalTextPrefix() { return OrderItemsRow.localTextPrefix; }
        protected form: OrderItemsForm;

        constructor() {
            super();
            this.form = new OrderItemsForm(this.idPrefix);   
            this.form.ProductId.changeSelect2(e => {
                debugger;
                var productID = Q.toId(this.form.ProductId.value);
                if (productID != null) {
                    var listOfProds = ProductRow.getLookup().itemById;

                    let g = listOfProds[productID]; 

                    this.form.UnitPrice.value = g?.UnitPrice;

                    //return Q.htmlEncode(g.UnitPrice);

                    this.form.Qty.value = 1;
                    this.form.ItemName.value = g.Name + " description";
                }
            });

           
        }
          
    }

}