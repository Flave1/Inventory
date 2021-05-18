namespace Inventory.Inventory {
    export interface ProductForm {
        Name: Serenity.StringEditor;
        UnitPrice: Serenity.DecimalEditor;
        SupplierId: Serenity.LookupEditor;
    }

    export class ProductForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.Product';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductForm.init)  {
                ProductForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(ProductForm, [
                    'Name', w0,
                    'UnitPrice', w1,
                    'SupplierId', w2
                ]);
            }
        }
    }
}
