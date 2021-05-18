namespace Inventory.Inventory {
    export interface OrderItemsForm {
        ProductId: Serenity.LookupEditor;
        Qty: Serenity.IntegerEditor;
        UnitPrice: Serenity.DecimalEditor;
        ItemName: Serenity.StringEditor;
    }

    export class OrderItemsForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.OrderItems';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderItemsForm.init)  {
                OrderItemsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.StringEditor;

                Q.initFormType(OrderItemsForm, [
                    'ProductId', w0,
                    'Qty', w1,
                    'UnitPrice', w2,
                    'ItemName', w3
                ]);
            }
        }
    }
}
