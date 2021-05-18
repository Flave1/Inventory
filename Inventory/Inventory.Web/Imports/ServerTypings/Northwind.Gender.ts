namespace Inventory.Northwind {
    export enum Gender {
        Male = 1,
        Female = 2
    }
    Serenity.Decorators.registerEnumType(Gender, 'Inventory.Northwind.Gender', 'Inventory.Northwind.Entities.Gender');
}
