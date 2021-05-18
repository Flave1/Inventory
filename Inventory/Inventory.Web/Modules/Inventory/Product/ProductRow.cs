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
    [ConnectionKey("Default"), Module("Inventory"), TableName("[inv].[Product]")]
    [DisplayName("Product"), InstanceName("Product")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [JsonConverter(typeof(JsonConverter))]

    [LookupScript]
    public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Product Id"), Identity, IdProperty]
        public Int64? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public String Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }
        [DisplayName("Unit Price"), Size(100), NotNull, QuickSearch, LookupInclude]
        public Decimal? UnitPrice
        {
            get => fields.UnitPrice[this];
            set => fields.UnitPrice[this] = value;
        }

        [DisplayName("Supplier"), NotNull, ForeignKey("[inv].[Supplier]", "SupplierId"), LeftJoin("jSupplier"), TextualField("SupplierCompanyName")] 
        [LookupEditor("Inventory.Suppliers")]
        public Int32? SupplierId
        {
            get => fields.SupplierId[this];
            set => fields.SupplierId[this] = value;
        }

        [DisplayName("Supplier User Id"), Expression("jSupplier.[UserId]")]
        public Int32? SupplierUserId
        {
            get => fields.SupplierUserId[this];
            set => fields.SupplierUserId[this] = value;
        }

        [DisplayName("Supplier Company Name"), Expression("jSupplier.[CompanyName]")]
        public String SupplierCompanyName
        {
            get => fields.SupplierCompanyName[this];
            set => fields.SupplierCompanyName[this] = value;
        }

        [DisplayName("Supplier Supplier Type"), Expression("jSupplier.[SupplierType]")]
        public Int32? SupplierSupplierType
        {
            get => fields.SupplierSupplierType[this];
            set => fields.SupplierSupplierType[this] = value;
        }

        public ProductRow()
            : base()
        {
        }

        public ProductRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field ProductId;
            public StringField Name;
            public Int32Field SupplierId;
            public DecimalField UnitPrice;
            public Int32Field SupplierUserId;
            public StringField SupplierCompanyName;
            public Int32Field SupplierSupplierType;
        }
    }
}
