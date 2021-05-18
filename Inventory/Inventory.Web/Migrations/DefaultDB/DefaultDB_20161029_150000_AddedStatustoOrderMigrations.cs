using FluentMigrator;

namespace Inventory.Migrations.DefaultDB
{
    [Migration(20161029_150000)]
    public class DefaultDB_20161029_150000_AddedStatustoOrderMigrations : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Orders").InSchema("inv")
                .AddColumn("Status").AsInt32().NotNullable().WithDefaultValue(1)
                .AddColumn("StatusFailedDescription").AsString().Nullable();
 
        }
    }
}