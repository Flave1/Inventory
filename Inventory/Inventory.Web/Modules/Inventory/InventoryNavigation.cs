using Serenity.Navigation;
using MyPages = Inventory.Inventory.Pages;

[assembly: NavigationLink(int.MaxValue, "Inventory/User Type", typeof(MyPages.UserTypeController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Inventory/Supplier", typeof(MyPages.SupplierController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Inventory/Product", typeof(MyPages.ProductController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Inventory/Orders", typeof(MyPages.OrdersController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Inventory/Order Items", typeof(MyPages.OrderItemsController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Inventory/Fulfillment Status", typeof(MyPages.FulfillmentStatusController), icon: null)]