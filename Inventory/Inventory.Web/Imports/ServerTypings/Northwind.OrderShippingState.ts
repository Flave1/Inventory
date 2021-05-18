namespace Inventory.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'Inventory.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
