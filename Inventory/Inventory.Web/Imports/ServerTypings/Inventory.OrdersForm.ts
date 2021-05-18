namespace Inventory.Inventory {
    export interface OrdersForm {
        CustomerId: Serenity.LookupEditor;
        OrderDecription: Serenity.StringEditor;
        OrderItems: OrderItemEditor;
    }

    export class OrdersForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.Orders';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrdersForm.init)  {
                OrdersForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = OrderItemEditor;

                Q.initFormType(OrdersForm, [
                    'CustomerId', w0,
                    'OrderDecription', w1,
                    'OrderItems', w2
                ]);
            }
        }
    }
}
