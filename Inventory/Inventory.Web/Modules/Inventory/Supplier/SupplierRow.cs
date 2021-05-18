using Inventory.Administration.Entities;
using Inventory.Web.Modules.Inventory.Enums;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Inventory.Inventory.Entities
{
    [ConnectionKey("Default"), Module("Inventory"), TableName("[inv].[Supplier]")]
    [DisplayName("Supplier"), InstanceName("Supplier")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Inventory.Suppliers")]
    public sealed class SupplierRow : Row<SupplierRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Supplier Id"), Identity, IdProperty]
        public Int32? SupplierId
        {
            get => fields.SupplierId[this];
            set => fields.SupplierId[this] = value;
        }

        [Width(300)]
        [DisplayName("User"), NotNull, ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUser"), TextualField("UserUsername")] 
        [LookupEditor("Administration.Users")]
        public Int32? UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

        [DisplayName("Company Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public String CompanyName
        {
            get => fields.CompanyName[this];
            set => fields.CompanyName[this] = value;
        }

        [DisplayName("Supplier Type"), NotNull]
        public SupplierTypes? SupplierType
        {
            get { return (SupplierTypes?)Fields.SupplierType[this]; }
            set { Fields.SupplierType[this] = (Int32?)value; }
        }
         
      
        [DisplayName("User Username"), Expression("jUser.[Username]")]
        public String UserUsername
        {
            get => fields.UserUsername[this];
            set => fields.UserUsername[this] = value;
        }

        [DisplayName("User Display Name"), Expression("jUser.[DisplayName]")]
        public String UserDisplayName
        {
            get => fields.UserDisplayName[this];
            set => fields.UserDisplayName[this] = value;
        }

        [DisplayName("User Email"), Expression("jUser.[Email]")]
        public String UserEmail
        {
            get => fields.UserEmail[this];
            set => fields.UserEmail[this] = value;
        }

        [DisplayName("User Source"), Expression("jUser.[Source]")]
        public String UserSource
        {
            get => fields.UserSource[this];
            set => fields.UserSource[this] = value;
        }

        [DisplayName("User Last Directory Update"), Expression("jUser.[LastDirectoryUpdate]")]
        public DateTime? UserLastDirectoryUpdate
        {
            get => fields.UserLastDirectoryUpdate[this];
            set => fields.UserLastDirectoryUpdate[this] = value;
        }

        [DisplayName("User User Image"), Expression("jUser.[UserImage]")]
        public String UserUserImage
        {
            get => fields.UserUserImage[this];
            set => fields.UserUserImage[this] = value;
        }

        [DisplayName("User Insert Date"), Expression("jUser.[InsertDate]")]
        public DateTime? UserInsertDate
        {
            get => fields.UserInsertDate[this];
            set => fields.UserInsertDate[this] = value;
        }

        [DisplayName("User Insert User Id"), Expression("jUser.[InsertUserId]")]
        public Int32? UserInsertUserId
        {
            get => fields.UserInsertUserId[this];
            set => fields.UserInsertUserId[this] = value;
        }

        [DisplayName("User Update Date"), Expression("jUser.[UpdateDate]")]
        public DateTime? UserUpdateDate
        {
            get => fields.UserUpdateDate[this];
            set => fields.UserUpdateDate[this] = value;
        }

        [DisplayName("User Update User Id"), Expression("jUser.[UpdateUserId]")]
        public Int32? UserUpdateUserId
        {
            get => fields.UserUpdateUserId[this];
            set => fields.UserUpdateUserId[this] = value;
        }

        [DisplayName("User Is Active"), Expression("jUser.[IsActive]")]
        public Int16? UserIsActive
        {
            get => fields.UserIsActive[this];
            set => fields.UserIsActive[this] = value;
        }

        [DisplayName("User User Type"), Expression("jUser.[UserType]")]
        public Int32? UserUserType
        {
            get => fields.UserUserType[this];
            set => fields.UserUserType[this] = value;
        }
         
        public SupplierRow()
            : base()
        {
        }

        public SupplierRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field SupplierId;
            public Int32Field UserId;
            public StringField CompanyName;
            public Int32Field SupplierType;

            public StringField UserUsername;
            public StringField UserDisplayName;
            public StringField UserEmail;
            public StringField UserSource;
            public DateTimeField UserLastDirectoryUpdate;
            public StringField UserUserImage;
            public DateTimeField UserInsertDate;
            public Int32Field UserInsertUserId;
            public DateTimeField UserUpdateDate;
            public Int32Field UserUpdateUserId;
            public Int16Field UserIsActive;
            public Int32Field UserUserType;
        }
    }
}
