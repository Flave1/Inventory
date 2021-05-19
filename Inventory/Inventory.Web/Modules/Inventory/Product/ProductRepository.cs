﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRow = Inventory.Inventory.Entities.ProductRow;

namespace Inventory.Inventory.Repositories
{
    public class ProductRepository : BaseRepository
    {
        private static MyRow.RowFields Fld => MyRow.Fields;

        public ProductRepository(IRequestContext context)
            : base(context)
        {
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler(Context).Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler(Context).Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler(Context).Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler(Context).Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler(Context).Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> 
        {
            public MySaveHandler(IRequestContext context)
                : base(context)
            {
            }
        }
        
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> 
        {
            public MyDeleteHandler(IRequestContext context)
                : base(context)
            {
            }
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> 
        {
            public MyRetrieveHandler(IRequestContext context)
                : base(context)
            {
            }
        }
        
        private class MyListHandler : ListRequestHandler<MyRow> 
        {
            public MyListHandler(IRequestContext context)
                : base(context)
            {
            }
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);
                var userTpe = Context.User.FindFirst(d => d.Type == "UserType")?.Value;
               
                if (User.Identity.Name != "admin")
                {
                    if (userTpe == "3")//  Suppliers
                    {
                        var userId = User.GetIdentifier();
                        query.Where(Fld.SupplierUserId == Convert.ToInt32(userId));
                    }
                    if (userTpe == "1")//  Employees
                    {
                        //All by default
                    }
                }
            }
        }
    }
}