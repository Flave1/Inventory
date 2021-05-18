using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Inventory.Inventory.Entities
{
    [ConnectionKey("Default"), Module("Inventory"), TableName("[inv].[OrderItems]")]
    [DisplayName("Order Items"), InstanceName("Order Items")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrderItemsRow : Row<OrderItemsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Order Item Id"), Identity, IdProperty]
        public Int64? OrderItemId
        {
            get => fields.OrderItemId[this];
            set => fields.OrderItemId[this] = value;
        }

        [DisplayName("Order"), ForeignKey("[inv].[Orders]", "OrderId"), LeftJoin("jOrder"), TextualField("OrderOrderDecription")] 
        public Int64? OrderId
        {
            get => fields.OrderId[this];
            set => fields.OrderId[this] = value;
        }

        [DisplayName("Order Date")]
        public DateTime? OrderDate
        {
            get => fields.OrderDate[this];
            set => fields.OrderDate[this] = value;
        }

        [DisplayName("Comment"), Size(100), QuickSearch, NameProperty]
        public String ItemName
        {
            get => fields.ItemName[this];
            set => fields.ItemName[this] = value;
        }

        [DisplayName("Qty"), Column("QTY"), NotNull]
        public Int32? Qty
        {
            get => fields.Qty[this];
            set => fields.Qty[this] = value;
        }

        [DisplayName("Unit Price"), Scale(4), NotNull, AlignRight, DisplayFormat("#,##0.00")]
        public Decimal? UnitPrice
        {
            get => fields.UnitPrice[this];
            set => fields.UnitPrice[this] = value;
        }

        [DisplayName("Product"), NotNull, ForeignKey("[inv].[Product]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductName")]
        [LookupEditor("Inventory.Product")]
        public Int64? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Sub Total"), Size(19), Scale(5)]
        public Decimal? SubTotal
        {
            get => fields.SubTotal[this];
            set => fields.SubTotal[this] = value;
        }

        [DisplayName("Order Customer Id"), Expression("jOrder.[CustomerId]")]
        public Int32? OrderCustomerId
        {
            get => fields.OrderCustomerId[this];
            set => fields.OrderCustomerId[this] = value;
        }

        [DisplayName("Order Order Date"), Expression("jOrder.[OrderDate]")]
        public DateTime? OrderOrderDate
        {
            get => fields.OrderOrderDate[this];
            set => fields.OrderOrderDate[this] = value;
        }

        [DisplayName("Order Total"), Expression("jOrder.[Total]")]
        public Decimal? OrderTotal
        {
            get => fields.OrderTotal[this];
            set => fields.OrderTotal[this] = value;
        }

        [DisplayName("Order Decription"), Expression("jOrder.[OrderDecription]")]
        public String OrderOrderDecription
        {
            get => fields.OrderOrderDecription[this];
            set => fields.OrderOrderDecription[this] = value;
        }

        [DisplayName("Product Name"), Expression("jProduct.[Name]")]
        public String ProductName
        {
            get => fields.ProductName[this];
            set => fields.ProductName[this] = value;
        }

        [DisplayName("Product Supplier Id"), Expression("jProduct.[SupplierId]")]
        public Int32? ProductSupplierId
        {
            get => fields.ProductSupplierId[this];
            set => fields.ProductSupplierId[this] = value;
        }

        public OrderItemsRow()
            : base()
        {
        }

        public OrderItemsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field OrderItemId;
            public Int64Field OrderId;
            public DateTimeField OrderDate;
            public StringField ItemName;
            public Int32Field Qty;
            public DecimalField UnitPrice;
            public Int64Field ProductId;
            public DecimalField SubTotal;

            public Int32Field OrderCustomerId;
            public DateTimeField OrderOrderDate;
            public DecimalField OrderTotal;
            public StringField OrderOrderDecription;

            public StringField ProductName;
            public Int32Field ProductSupplierId;
        }
    }
}
