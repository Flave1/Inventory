using FluentMigrator;

namespace Inventory.Migrations.DefaultDB
{
    [Migration(20162029_163000)]
    public class DefaultDB_20161029_163000_AddedPriceToProductsMigration : AutoReversingMigration
    {
        public override void Up()
        { 
            Alter.Table("Product").InSchema("inv")
                .AddColumn("UnitPrice").AsDecimal().NotNullable().WithDefaultValue(0); 
        }
    }
}