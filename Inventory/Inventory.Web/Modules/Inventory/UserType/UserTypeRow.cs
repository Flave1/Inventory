using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json.Serialization;

namespace Inventory.Inventory.Entities
{
    [ConnectionKey("Default"), Module("Inventory"), TableName("[inv].[UserType]"), TwoLevelCached]
    [DisplayName("User Type"), InstanceName("User Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]

    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("Inventory.UserType")]
    public sealed class UserTypeRow : Row<UserTypeRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("User Type Id"), Identity, IdProperty]
        public Int32? UserTypeId
        {
            get => fields.UserTypeId[this];
            set => fields.UserTypeId[this] = value;
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public String Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        public UserTypeRow()
            : base()
        {
        }

        public UserTypeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field UserTypeId;
            public StringField Name;
        }
    }
}
