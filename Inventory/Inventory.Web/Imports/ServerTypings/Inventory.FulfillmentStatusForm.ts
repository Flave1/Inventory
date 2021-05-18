namespace Inventory.Inventory {
    export interface FulfillmentStatusForm {
        StatusName: Serenity.StringEditor;
    }

    export class FulfillmentStatusForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.FulfillmentStatus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!FulfillmentStatusForm.init)  {
                FulfillmentStatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(FulfillmentStatusForm, [
                    'StatusName', w0
                ]);
            }
        }
    }
}
