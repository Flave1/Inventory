using Inventory.Web.Modules.Inventory.Enums;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json.Serialization;

namespace Inventory.Inventory.Entities
{
    [ConnectionKey("Default"), Module("Inventory"), TableName("[inv].[Orders]")]
    [DisplayName("Orders"), InstanceName("Orders")]
    [ReadPermission(PermissionKeys.Orders.View)]
    [ModifyPermission(PermissionKeys.Orders.Modify)]
    [JsonConverter(typeof(JsonConverter))]
    [LookupScript("Inventory.Orders")]
    public sealed class OrdersRow : Row<OrdersRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Order Id"), Identity, IdProperty]
        public Int64? OrderId
        {
            get => fields.OrderId[this];
            set => fields.OrderId[this] = value;
        }

        [DisplayName("Customer"), NotNull, ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jCustomer"), TextualField("CustomerUsername")]
        [LookupEditor("Administration.Users")]
        public Int32? CustomerId
        {
            get => fields.CustomerId[this];
            set => fields.CustomerId[this] = value;
        }

        [DisplayName("Order Date")]
        public DateTime? OrderDate
        {
            get => fields.OrderDate[this];
            set => fields.OrderDate[this] = value;
        }

        [DisplayName("Total"), Size(19), Scale(5)]
        public Decimal? Total
        {
            get => fields.Total[this];
            set => fields.Total[this] = value;
        }

        [DisplayName("Order Decription"), Size(255), NotNull, QuickSearch, NameProperty]
        public String OrderDecription
        {
            get => fields.OrderDecription[this];
            set => fields.OrderDecription[this] = value;
        }

        [DisplayName("Order Status"), ForeignKey(typeof(FulfillmentStatusRow)), LeftJoin("g"), LookupInclude]
        [LookupEditor(typeof(FulfillmentStatusRow), InplaceAdd = true)]
        public Int32? Status
        {
            get => fields.Status[this];
            set => fields.Status[this] = value;
        }

        [Width(200)]

        [DisplayName("Order failed reason"), Size(24)]
        public String StatusFailedDescription
        {
            get => fields.StatusFailedDescription[this];
            set => fields.StatusFailedDescription[this] = value;
        }

        [Origin("g"), DisplayName("Order Status")]
        public String StatusName
        {
            get => fields.StatusName[this];
            set => fields.StatusName[this] = value;
        }


        [DisplayName("Customer Username"), Expression("jCustomer.[Username]")]
        public String CustomerUsername
        {
            get => fields.CustomerUsername[this];
            set => fields.CustomerUsername[this] = value;
        }

        [DisplayName("Customer Display Name"), Expression("jCustomer.[DisplayName]")]
        public String CustomerDisplayName
        {
            get => fields.CustomerDisplayName[this];
            set => fields.CustomerDisplayName[this] = value;
        }

        [DisplayName("Customer Email"), Expression("jCustomer.[Email]")]
        public String CustomerEmail
        {
            get => fields.CustomerEmail[this];
            set => fields.CustomerEmail[this] = value;
        }

        [DisplayName("Customer Source"), Expression("jCustomer.[Source]")]
        public String CustomerSource
        {
            get => fields.CustomerSource[this];
            set => fields.CustomerSource[this] = value;
        }

        [DisplayName("Customer Last Directory Update"), Expression("jCustomer.[LastDirectoryUpdate]")]
        public DateTime? CustomerLastDirectoryUpdate
        {
            get => fields.CustomerLastDirectoryUpdate[this];
            set => fields.CustomerLastDirectoryUpdate[this] = value;
        }

        [DisplayName("Customer User Image"), Expression("jCustomer.[UserImage]")]
        public String CustomerUserImage
        {
            get => fields.CustomerUserImage[this];
            set => fields.CustomerUserImage[this] = value;
        }

        [DisplayName("Customer Insert Date"), Expression("jCustomer.[InsertDate]")]
        public DateTime? CustomerInsertDate
        {
            get => fields.CustomerInsertDate[this];
            set => fields.CustomerInsertDate[this] = value;
        }

        [DisplayName("Customer Insert User Id"), Expression("jCustomer.[InsertUserId]")]
        public Int32? CustomerInsertUserId
        {
            get => fields.CustomerInsertUserId[this];
            set => fields.CustomerInsertUserId[this] = value;
        }

        [DisplayName("Customer Update Date"), Expression("jCustomer.[UpdateDate]")]
        public DateTime? CustomerUpdateDate
        {
            get => fields.CustomerUpdateDate[this];
            set => fields.CustomerUpdateDate[this] = value;
        }

        [DisplayName("Customer Update User Id"), Expression("jCustomer.[UpdateUserId]")]
        public Int32? CustomerUpdateUserId
        {
            get => fields.CustomerUpdateUserId[this];
            set => fields.CustomerUpdateUserId[this] = value;
        }

        [DisplayName("Customer Is Active"), Expression("jCustomer.[IsActive]")]
        public Int16? CustomerIsActive
        {
            get => fields.CustomerIsActive[this];
            set => fields.CustomerIsActive[this] = value;
        }

        [DisplayName("Customer User Type"), Expression("jCustomer.[UserType]")]
        public Int32? CustomerUserType
        {
            get => fields.CustomerUserType[this];
            set => fields.CustomerUserType[this] = value;
        }

        [DisplayName("Order Items"), MasterDetailRelation(foreignKey: "OrderId"), NotMapped]
        public List<OrderItemsRow> OrderItems
        {
            get => fields.OrderItems[this];
            set => fields.OrderItems[this] = value;
        } 

        public OrdersRow()
            : base()
        {
        }

        public OrdersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field OrderId;
            public Int32Field CustomerId;
            public DateTimeField OrderDate;
            public DecimalField Total;
            public StringField OrderDecription;

            public StringField CustomerUsername;
            public StringField CustomerDisplayName;
            public StringField CustomerEmail;
            public StringField CustomerSource;
            public DateTimeField CustomerLastDirectoryUpdate;
            public StringField CustomerUserImage;
            public DateTimeField CustomerInsertDate;
            public Int32Field CustomerInsertUserId;
            public DateTimeField CustomerUpdateDate;
            public Int32Field CustomerUpdateUserId;
            public Int16Field CustomerIsActive;
            public Int32Field CustomerUserType;
            public readonly Int32Field Status;
            public readonly StringField StatusName; 
            public StringField StatusFailedDescription;
            public readonly RowListField<OrderItemsRow> OrderItems;
        }
    }
}
