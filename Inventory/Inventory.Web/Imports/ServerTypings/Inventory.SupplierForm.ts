namespace Inventory.Inventory {
    export interface SupplierForm {
        UserId: Serenity.LookupEditor;
        CompanyName: Serenity.StringEditor;
        SupplierType: Serenity.EnumEditor;
    }

    export class SupplierForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.Supplier';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SupplierForm.init)  {
                SupplierForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.EnumEditor;

                Q.initFormType(SupplierForm, [
                    'UserId', w0,
                    'CompanyName', w1,
                    'SupplierType', w2
                ]);
            }
        }
    }
}
