namespace Inventory.Inventory {
    export interface UserTypeForm {
        Name: Serenity.StringEditor;
    }

    export class UserTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.UserType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserTypeForm.init)  {
                UserTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(UserTypeForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
