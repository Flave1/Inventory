using FluentMigrator;

namespace Inventory.Migrations.DefaultDB
{
    [Migration(20162029_160000)]
    public class DefaultDB_162000_OrderStatusMigrations : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Table("FulfillmentStatus").InSchema("inv").WithColumn("StatusId")
                .AsInt32().NotNullable().PrimaryKey().Identity().WithColumn("StatusName").AsString().NotNullable();

          Insert.IntoTable("FulfillmentStatus").InSchema("inv")
          .Row(new
          {
              StatusName = "Pending", 
          })
          .Row(new
          {
              StatusName = "Complete", 
          })
          .Row(new
          {
              StatusName = "Failed", 
          });


            Alter.Table("Orders").InSchema("inv")
                .AlterColumn("Status").AsInt32().NotNullable().WithDefaultValue(1).ForeignKey("Orders_FulfillmentStatus", "inv", "FulfillmentStatus", "StatusId");

        }
    }
}