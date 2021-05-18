using FluentMigrator;
using Inventory.Web.Modules.Inventory.Enums;

namespace Inventory.Migrations.DefaultDB
{
    [Migration(20161029_160000)]
    public class DefaultDB_20161029_160000_AddedStatusTableMigrations : AutoReversingMigration
    {
        public override void Up()
        { 

            Create.Table("FulfillmentStatus").InSchema("inv")
           .WithColumn("StatusId").AsInt32().NotNullable()
              .PrimaryKey().Identity()
              .WithColumn("StatusName").AsString().NotNullable()
              .WithColumn("TypeOf").AsInt32().NotNullable();

          Insert.IntoTable("FulfillmentStatus").InSchema("inv")
          .Row(new
          {
              StatusName = "Pending",
              TypeOf = (int)FulfillmentStatusEnum.Pending
          })
          .Row(new
          {
              StatusName = "Complete",
              TypeOf = (int)FulfillmentStatusEnum.Complete
          })
          .Row(new
          {
              StatusName = "Failed",
              TypeOf = (int)FulfillmentStatusEnum.Failed
          });


            Alter.Table("Orders").InSchema("inv")
                .AlterColumn("Status").AsInt32().NotNullable().WithDefaultValue(1).ForeignKey("Orders_FulfillmentStatus", "inv", "FulfillmentStatus", "StatusId");


        }
    }
}