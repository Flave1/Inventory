using FluentMigrator;

namespace Inventory.Migrations.DefaultDB
{
    [Migration(20161029_140000)]
    public class DefaultDB_20161029_140000_InventoryMigrations : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Schema("inv");

            Create.Table("UserType").InSchema("inv")
               .WithColumn("UserTypeId").AsInt32().NotNullable()
                   .PrimaryKey().Identity()
                        .WithColumn("Name").AsString(100).NotNullable();

            Insert.IntoTable("UserType").InSchema("inv")
            .Row(new
            { 
                Name = "Employee",
            })
                   .Row(new
                   { 
                       Name = "Customer",
                   })
                      .Row(new
                      { 
                          Name = "Supplier",
                      });


            Alter.Table("Users").InSchema("dbo")
                .AddColumn("UserType").AsInt32().NotNullable().WithDefaultValue(1)
                    .ForeignKey("FK_Users_UserTypeId", "inv", "UserType", "UserTypeId");


            Create.Table("Supplier").InSchema("inv")
               .WithColumn("SupplierId").AsInt32().NotNullable()
                   .PrimaryKey().Identity()
               .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("FK_Supplier_UserId", "dbo", "Users", "UserId")
               .WithColumn("CompanyName").AsString(200).NotNullable()
               .WithColumn("SupplierType").AsInt32().NotNullable();


            Create.Table("Product").InSchema("inv")
            .WithColumn("ProductId").AsInt64().NotNullable()
             .PrimaryKey().Identity()
                  .WithColumn("Name").AsString(100).NotNullable()
                  .WithColumn("SupplierId").AsInt32().NotNullable()
                   .ForeignKey("FK_Product_SupplierId", "inv", "Supplier", "SupplierId");


            Create.Table("Orders").InSchema("inv")
           .WithColumn("OrderId").AsInt64().NotNullable()
            .PrimaryKey().Identity()
                 .WithColumn("CustomerId").AsInt32().NotNullable()
                  .ForeignKey("FK_Users_UserId", "dbo", "Users", "UserId")
                  .WithColumn("OrderDate").AsDateTime().NotNullable()
            .WithColumn("Total").AsDecimal().NotNullable()
            .WithColumn("OrderDecription").AsString().NotNullable();
             

        Create.Table("OrderItems").InSchema("inv")
                .WithColumn("OrderItemId").AsInt64().NotNullable()
                 .PrimaryKey().Identity()
                 .WithColumn("OrderId").AsInt64().NotNullable()
                 .ForeignKey("FK_OrderItems_OrderId", "inv", "Orders", "OrderId")
                 .WithColumn("OrderDate").AsDateTime().NotNullable()
                  .WithColumn("ItemName").AsString(100).NotNullable()
                  .WithColumn("QTY").AsInt32().NotNullable()
                  .WithColumn("UnitPrice").AsDecimal().NotNullable()
                  .WithColumn("ProductId").AsInt64().NotNullable()
                  .ForeignKey("FK_OrderItems_ProductId", "inv", "Product", "ProductId")
                  .WithColumn("SubTotal").AsDecimal().NotNullable();
        }
    }
}