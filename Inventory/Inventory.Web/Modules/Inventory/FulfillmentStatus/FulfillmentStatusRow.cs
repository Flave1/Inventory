using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Inventory.Inventory.Entities
{
    [ConnectionKey("Default"), Module("Inventory"), TableName("[inv].[FulfillmentStatus]")]
    [DisplayName("Fulfillment Status"), InstanceName("Fulfillment Status")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Inventory.FulfillmentStatus")]
    public sealed class FulfillmentStatusRow : Row<FulfillmentStatusRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Status Id"), Identity, IdProperty]
        public Int32? StatusId
        {
            get => fields.StatusId[this];
            set => fields.StatusId[this] = value;
        }

        [DisplayName("Status Name"), Size(255), NotNull, QuickSearch, NameProperty]
        public String StatusName
        {
            get => fields.StatusName[this];
            set => fields.StatusName[this] = value;
        }

        public FulfillmentStatusRow()
            : base()
        {
        }

        public FulfillmentStatusRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field StatusId;
            public StringField StatusName;
        }
    }
}
